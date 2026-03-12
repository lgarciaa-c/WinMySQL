using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;
using WINMYSQL.LISTAS;
using OfficeOpenXMl;

namespace WINMYSQL.VISTAS
{
    public partial class FrmAlumnos : Form
    {
        OpenFileDialog ofdExcel = new OpenFileDialog();
        Datos Datos = new Datos();
        DataSet ds;
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno();
            alumno.ShowDialog();
        }

        private void FrmAlumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = Datos.ejecutar("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                ds = Datos.ejecutar("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAlumno Alumno = new FrmAlumno(Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
                                                             dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                                                             dgvAlumnos.CurrentRow.Cells[2].Value.ToString());
            Alumno.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idAlumnos = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas Eliminar El Alumno:"
                + dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = Datos.ejecutarcomando($"Delete from Alumnos where idAlumnos={idAlumnos}");
                if (f)
                {
                    MessageBox.Show("Alumno Eliminado", "Sistema");

                }
                else
                {
                    MessageBox.Show("Error", "Sistema");
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Giovanni");
                using (ExcelPackage excel = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet ws = excel.Workbook.Worksheets[0];
                    int rowCount = ws.Dimension.Rows;
                    int columnn = ws.Dimension.Columns;
                    DataTable dt = new DataTable();
                    for (int col = 1; col <= columnn; col++)
                    {
                        dt.Columns.Add(ws.Cells[1, col].Value.ToString());
                    }
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow drnew = dt.NewRow();
                        for (int col = 1; col <= columnn; col++)
                        {
                            drnew[col - 1] = ws.Cells[row, col].Value.ToString();
                        }
                        dt.Rows.Add(drnew);
                        String comando;
                    }
                }
            }
        }
    }
}
