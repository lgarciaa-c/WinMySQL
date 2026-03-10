namespace WINMYSQL.VISTAS
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
            btnAgregarAlumnos = new Button();
            txtAlumnos = new TextBox();
            label1 = new Label();
            dgvAlumnos = new DataGridView();
            cmsDataA = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            cmsDataA.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnAgregarAlumnos);
            splitContainer1.Panel1.Controls.Add(txtAlumnos);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAlumnos);
            splitContainer1.Size = new Size(817, 495);
            splitContainer1.SplitterDistance = 118;
            splitContainer1.TabIndex = 0;
            // 
            // btnAgregarAlumnos
            // 
            btnAgregarAlumnos.Location = new Point(653, 61);
            btnAgregarAlumnos.Name = "btnAgregarAlumnos";
            btnAgregarAlumnos.Size = new Size(94, 29);
            btnAgregarAlumnos.TabIndex = 2;
            btnAgregarAlumnos.Text = "AGREGAR";
            btnAgregarAlumnos.UseVisualStyleBackColor = true;
            btnAgregarAlumnos.Click += btnAgregarAlumnos_Click;
            // 
            // txtAlumnos
            // 
            txtAlumnos.Location = new Point(39, 61);
            txtAlumnos.Name = "txtAlumnos";
            txtAlumnos.Size = new Size(558, 27);
            txtAlumnos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 28);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(817, 373);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellContentDoubleClick += dgvAlumnos_CellContentDoubleClick;
            // 
            // cmsDataA
            // 
            cmsDataA.ImageScalingSize = new Size(20, 20);
            cmsDataA.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsDataA.Name = "cmsDataA";
            cmsDataA.Size = new Size(211, 56);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(210, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 495);
            Controls.Add(splitContainer1);
            Name = "FrmAlumnos";
            Text = "FrmAlumnos";
            Activated += FrmAlumnos_Activated;
            Load += FrmAlumnos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            cmsDataA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtAlumnos;
        private Label label1;
        private DataGridView dgvAlumnos;
        private Button btnAgregarAlumnos;
        private ContextMenuStrip cmsDataA;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}