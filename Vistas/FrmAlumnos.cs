using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Vistas
{
    public partial class FrmAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        OpenFileDialog ofdExcel = new OpenFileDialog();
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void FrmAlumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutarComando("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutarComando("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FrmAlumno alumn = new FrmAlumno();
            alumn.Show();
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno(
              Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
              dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
              dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
              dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
              Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value));
            alumno.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idalumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);

            string nombreCompleto = dgvAlumnos.CurrentRow.Cells[3].Value.ToString() + " " +
                                    dgvAlumnos.CurrentRow.Cells[1].Value.ToString() + " " +
                                    dgvAlumnos.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show("¿Deseas eliminar al alumno: " + nombreCompleto + "?",
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarcomando($"DELETE FROM Alumnos WHERE CONTROL={idalumno}");
                if (f == true)
                {
                    MessageBox.Show("Alumno eliminado con éxito", "Sistema");
                    FrmAlumnos_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error al eliminar al alumno", "Sistema");
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Luis Mota");

                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int errores = 0;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        string control = worksheet.Cells[row, 1].Value?.ToString() ?? "";
                        string paterno = worksheet.Cells[row, 2].Value?.ToString() ?? "";
                        string materno = worksheet.Cells[row, 3].Value?.ToString() ?? "";
                        string nombre = worksheet.Cells[row, 4].Value?.ToString() ?? "";

                        string comando = $"INSERT INTO Alumnos (CONTROL, Paterno, Materno, Nombre) " +
                                         $"VALUES ({control}, '{paterno}', '{materno}', '{nombre}')";

                        bool ok = datos.ejecutarcomando(comando);
                        if (!ok) errores++;
                    }

                    FrmAlumnos_Load(sender, e);

                    if (errores == 0)
                        MessageBox.Show($"¡Listo! {rowCount - 1} alumnos cargados correctamente.", "Sistema");
                    else
                        MessageBox.Show($"Se cargaron con {errores} errores de {rowCount - 1} registros.", "Sistema");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar TODOS los alumnos?",
                 "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool f = datos.ejecutarcomando("DELETE FROM Alumnos");
                if (f)
                {
                    MessageBox.Show("Tabla limpiada correctamente", "Sistema");
                    FrmAlumnos_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error al limpiar la tabla", "Sistema");
                }
            }
        }

        private void dgvAlumnos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvAlumnos.Rows[e.RowIndex];

                string control = row.Cells[0].Value?.ToString() ?? "";
                string paterno = row.Cells[1].Value?.ToString() ?? "";
                string materno = row.Cells[2].Value?.ToString() ?? "";
                string nombre = row.Cells[3].Value?.ToString() ?? "";

                bool ok = datos.ejecutarcomando(
                    $"UPDATE Alumnos SET " +
                    $"Paterno='{paterno}', " +
                    $"Materno='{materno}', " +
                    $"Nombre='{nombre}' " +
                    $"WHERE CONTROL={control}");

                if (ok)
                    MessageBox.Show("Alumno actualizado correctamente.", "Sistema");
                else
                    MessageBox.Show("Error al actualizar el alumno.", "Sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error");
            }
        }
    }
}
