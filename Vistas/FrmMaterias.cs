using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WINMYSQL.CLASES;
using WINMYSQL.VISTAS;

namespace WINMYSQL.LISTAS
{
    public partial class FrmMaterias : Form
    {
        Datos Datos = new Datos();
        DataSet ds;
        public FrmMaterias()
        {
            InitializeComponent();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            FrmMateria materia = new FrmMateria();
            materia.ShowDialog();
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            try
            {
                ds = Datos.ejecutar("Select * from Materia");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }


        }

        private void FrmMaterias_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = Datos.ejecutar("Select * from Materia");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { }
        }

        private void dgvMaterias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmMateria materia = new FrmMateria(Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value),
                                                                dgvMaterias.CurrentRow.Cells[1].Value.ToString(),
                                                                dgvMaterias.CurrentRow.Cells[2].Value.ToString());
            materia.ShowDialog();
        }

        private void btnAgregarMaterias_Click(object sender, EventArgs e)
        {
            FrmMateria materia = new FrmMateria();
            materia.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idMateria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value);
            if(MessageBox.Show("Deseas Eliminar la Materia:" 
                + dgvMaterias.CurrentRow.Cells[1].Value.ToString(),
                "Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question ) == DialogResult.Yes)
            {
                bool f = Datos.ejecutarcomando($"Delete from Materia where idMateria={idMateria}");
                if (f)
                {
                    MessageBox.Show("Materia Eliminada","Sistema");
                    
                }
                else
                {
                    MessageBox.Show("Error", "Sistema");
                }
            }
        }
    }
}
