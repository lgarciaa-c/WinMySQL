namespace WinMySQL.Vistas
{
    partial class FrmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnLimpiar = new Button();
            btnInsertar = new Button();
            btnAgregarAlumno = new Button();
            txtMaterias = new TextBox();
            label1 = new Label();
            dgvAlumnos = new DataGridView();
            cmsAlumno = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            cmsAlumno.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Green;
            splitContainer1.Panel1.Controls.Add(btnLimpiar);
            splitContainer1.Panel1.Controls.Add(btnInsertar);
            splitContainer1.Panel1.Controls.Add(btnAgregarAlumno);
            splitContainer1.Panel1.Controls.Add(txtMaterias);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAlumnos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 105;
            splitContainer1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Cyan;
            btnLimpiar.Location = new Point(689, 52);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Eliminar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Cyan;
            btnInsertar.Location = new Point(579, 19);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.BackColor = Color.Cyan;
            btnAgregarAlumno.Location = new Point(579, 62);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(75, 23);
            btnAgregarAlumno.TabIndex = 5;
            btnAgregarAlumno.Text = "Agregar";
            btnAgregarAlumno.UseVisualStyleBackColor = false;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // txtMaterias
            // 
            txtMaterias.Location = new Point(12, 41);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(531, 23);
            txtMaterias.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 3;
            label1.Text = "Buscar";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.ContextMenuStrip = cmsAlumno;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(800, 341);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellContentDoubleClick += dgvAlumnos_CellContentDoubleClick;
            dgvAlumnos.CellEndEdit += dgvAlumnos_CellEndEdit;
            // 
            // cmsAlumno
            // 
            cmsAlumno.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsAlumno.Name = "cmsAlumno";
            cmsAlumno.Size = new Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmAlumnos";
            Text = "Alumnos";
            Activated += FrmAlumnos_Activated;
            Load += FrmAlumnos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            cmsAlumno.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvAlumnos;
        private Button btnAgregarAlumno;
        private TextBox txtMaterias;
        private Label label1;
        private ContextMenuStrip cmsAlumno;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnInsertar;
        private Button btnLimpiar;
    }
}