using System;
using System.Data;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Vistas
{
    public partial class FrmAsistencia : Form
    {

        Datos datos = new Datos();

        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = DateTime.Today;
                CargarAlumnos();
                txtNum.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la fecha: " + ex.Message, "Error");
            }
        }

        private void CargarAlumnos()
        {
            try
            {
                string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                DataSet ds = datos.ejecutarComando(
                    $"SELECT a.CONTROL, a.Nombre, a.Paterno, a.Materno, " +
                    $"CASE WHEN r.Asistio IS NOT NULL THEN r.Asistio ELSE 'No' END AS Asistio " +
                    $"FROM Alumnos a " +
                    $"LEFT JOIN Asistencia r ON a.CONTROL = r.Control AND r.Fecha = '{fecha}'");

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    DataColumn col = new DataColumn("Presente", typeof(bool));
                    col.DefaultValue = false;
                    dt.Columns.Add(col);

                    foreach (DataRow row in dt.Rows)
                        row["Presente"] = row["Asistio"].ToString() == "Si";

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["Presente"].ReadOnly = false;
                    dataGridView1.Columns["Asistio"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay alumnos registrados.", "Sistema");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alumnos: " + ex.Message, "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                datos.ejecutarcomando($"DELETE FROM Asistencia WHERE Fecha='{fecha}'");

                int guardados = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string control = row.Cells["CONTROL"].Value?.ToString() ?? "";
                    bool presente = Convert.ToBoolean(row.Cells["Presente"].Value);
                    string asistio = presente ? "Si" : "No";

                    bool ok = datos.ejecutarcomando(
                        $"INSERT INTO Asistencia (Control, Fecha, Asistio) " +
                        $"VALUES ('{control}', '{fecha}', '{asistio}')");

                    if (ok) guardados++;
                }

                int totalPresentes = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (Convert.ToBoolean(row.Cells["Presente"].Value))
                        totalPresentes++;
                }

                MessageBox.Show($"Asistencia guardada: {totalPresentes} alumnos presentes de {dataGridView1.Rows.Count - 1} total.", "Sistema");
                CargarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar asistencia: " + ex.Message, "Error");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;

                string control = dataGridView1.CurrentRow.Cells["CONTROL"].Value?.ToString() ?? "";
                string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                bool ok = datos.ejecutarcomando(
                    $"DELETE FROM Asistencia WHERE Control='{control}' AND Fecha='{fecha}'");

                if (ok)
                {
                    MessageBox.Show("Registro eliminado.", "Sistema");
                    CargarAlumnos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar.", "Sistema");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bool actual = Convert.ToBoolean(row.Cells["Presente"].Value);
                row.Cells["Presente"].Value = !actual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar asistencia: " + ex.Message, "Error");
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int rowIndex = dataGridView1.CurrentCell?.RowIndex ?? -1;
                    if (rowIndex < 0) return;

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    bool actual = Convert.ToBoolean(row.Cells["Presente"].Value);
                    row.Cells["Presente"].Value = !actual;

                    if (rowIndex + 1 < dataGridView1.Rows.Count)
                        dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex + 1].Cells[0];

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string control = txtNum.Text.Trim();

                if (string.IsNullOrEmpty(control))
                {
                    CargarAlumnos();
                    return;
                }

                // ✅ Buscar el alumno en el DataGridView y marcar la palomita
                bool encontrado = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["CONTROL"].Value?.ToString() == control)
                    {
                        row.Cells["Presente"].Value = true;
                        dataGridView1.ClearSelection();
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                    MessageBox.Show("Alumno no encontrado.", "Sistema");

                txtNum.Clear();
                txtNum.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar alumno: " + ex.Message, "Error");
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string control = txtNum.Text.Trim();
                    if (string.IsNullOrEmpty(control)) return;

                    bool encontrado = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        if (row.Cells["CONTROL"].Value?.ToString() == control)
                        {
                            row.Cells["Presente"].Value = true; 
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        MessageBox.Show("Alumno no encontrado.", "Sistema");

                    txtNum.Clear();
                    txtNum.Focus();
                    e.Handled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
    }
}
