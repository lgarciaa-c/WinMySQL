using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WINMYSQL.CLASES;

namespace WINMYSQL.VISTAS
{
    public partial class FrmMateria : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public FrmMateria()
        {


            InitializeComponent();
        }

        public FrmMateria(int id, string Materia, string cve)
        {
            InitializeComponent();
            this.id = id;
            txtMateria.Text = Materia;
            txtClaveMateria.Text = cve;
            updating = true;

        }

        private void FrmMateria_Load(object sender, EventArgs e)
        {


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarcomando(
                    $"Insert into Materia (Materia,CVE) " +
                    $"values ('{txtMateria.Text}','{txtClaveMateria.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la materia");
                }
            }
            else
            {
                bool resultado = dt.ejecutarcomando(
                    $"Update Materia set Materia='{txtMateria.Text}', CVE='{txtClaveMateria.Text}' " +
                    $"where idMateria={id}");
                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la materia");
                }
            }
        }
    }
}
