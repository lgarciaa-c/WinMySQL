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
    public partial class FrmProfesor : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public FrmProfesor()
        {
            InitializeComponent();
        }

        public FrmProfesor(int id, string Profesor, string cve)
        {
            InitializeComponent();
            this.id = id;
            txtProfesor.Text = Profesor;
            txtClave.Text = cve;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarcomando(
                    $"Insert into Profesor (Profesor,CVE) " +
                    $"values ('{txtProfesor.Text}','{txtClave.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la Profesor");
                }
            }
            else
            {
                bool resultado = dt.ejecutarcomando(
                    $"Update Profesor set Profesor='{txtProfesor.Text}', CVE='{txtClave.Text}' " +
                    $"where idProfesor={id}");
                if (resultado)
                {
                    MessageBox.Show("Profesor actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el Profesor");
                }
            }
        }
    }
}
