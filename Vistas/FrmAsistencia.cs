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
            dateTimePicker1.Value = DateTime.Today;
            CargarAlumnos();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            // Traer todos los alumnos y si ya tienen asistencia ese día
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

                // Marcar los que ya tienen asistencia "Si"
                foreach (DataRow row in dt.Rows)
                {
                    row["Presente"] = row["Asistio"].ToString() == "Si";
                }

                dataGridView1.DataSource = dt;

                // Hacer la columna Presente editable como checkbox
                dataGridView1.Columns["Presente"].ReadOnly = false;
                dataGridView1.Columns["Asistio"].Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            bool actual = Convert.ToBoolean(row.Cells["Presente"].Value);
            row.Cells["Presente"].Value = !actual;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowIndex = dataGridView1.CurrentCell?.RowIndex ?? -1;
                if (rowIndex < 0) return;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                bool actual = Convert.ToBoolean(row.Cells["Presente"].Value);
                row.Cells["Presente"].Value = !actual;

                // Bajar a la siguiente fila automáticamente
                if (rowIndex + 1 < dataGridView1.Rows.Count)
                    dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex + 1].Cells[0];

                e.Handled = true;
            }
        }

      
    }
}
