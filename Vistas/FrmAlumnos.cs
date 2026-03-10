using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WINMYSQL.CLASES;
using WINMYSQL.LISTAS;

namespace WINMYSQL.VISTAS
{
    public partial class FrmAlumnos : Form
    {
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

    }
}
