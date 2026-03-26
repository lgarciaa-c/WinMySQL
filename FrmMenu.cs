using WinMySQL.Vistas;

namespace WinMySQL
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumnos alum = new FrmAlumnos();
            alum.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias mate = new frmMaterias();
            mate.ShowDialog();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesores profe = new FrmProfesores();
            profe.Show();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsistencia asi = new FrmAsistencia();
            asi.Show();
        }
    }
}
