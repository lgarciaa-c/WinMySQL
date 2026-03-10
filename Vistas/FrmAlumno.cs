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
    public partial class FrmAlumno : Form
    {
        int id = 0;
        bool updating = false;
        Datos dt = new Datos();
        public FrmAlumno()
        {
            InitializeComponent();
        }

        public FrmAlumno(int id, string Alumno, string num)
        {
            InitializeComponent();
            this.id = id;
            txtAlumno.Text = Alumno;
            txtNumControl.Text = num;
            updating = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarcomando(
                    $"Insert into Alumnos (Alumno,nControl) " +
                    $"values ('{txtAlumno.Text}','{txtNumControl.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la Alumno");
                }
            }
            else
            {
                bool resultado = dt.ejecutarcomando(
                    $"Update Alumnos set Alumno='{txtAlumno.Text}', CVE='{txtNumControl.Text}' " +
                    $"where idAlumnos={id}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el Alumno");
                }
            }
        }
    }
}
