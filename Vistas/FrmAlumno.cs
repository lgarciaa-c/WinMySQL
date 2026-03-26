using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Vistas
{
    public partial class FrmAlumno : Form
    {
        Datos datos = new Datos();
        bool updating = false;
        int id = 0;
        public FrmAlumno()
        {
            InitializeComponent();
        }
        public FrmAlumno(int id, String Nombre, String paterno, String Materno, int NC)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = Nombre;
            txtPaterno.Text = paterno;
            txtMaterno.Text = Materno;
            txtNumeroControl.Text = NC.ToString();
            updating = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = datos.ejecutarcomando(
                 $"INSERT INTO Alumnos (CONTROL, Nombre, Paterno, Materno) " +
                    $"VALUES ({txtNumeroControl.Text}, '{txtNombre.Text}', '{txtPaterno.Text}', '{txtMaterno.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Alumno");
                }
            }
            else
            {
                bool resultado = datos.ejecutarcomando(
                    $"UPDATE Alumnos SET " +
                    $"Nombre='{txtNombre.Text}', " +
                    $"Paterno='{txtPaterno.Text}', " +
                    $"Materno='{txtMaterno.Text}' " +
                    $"WHERE CONTROL={id}");

                if (resultado)
                {
                    MessageBox.Show("Alumno actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar al Alumno");
                }
            }
        }
    }
}
