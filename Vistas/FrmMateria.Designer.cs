namespace WINMYSQL.VISTAS
{
    partial class FrmMateria
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
            txtMateria = new TextBox();
            txtClaveMateria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(79, 74);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(419, 27);
            txtMateria.TabIndex = 0;
            // 
            // txtClaveMateria
            // 
            txtClaveMateria.Location = new Point(79, 160);
            txtClaveMateria.Name = "txtClaveMateria";
            txtClaveMateria.Size = new Size(419, 27);
            txtClaveMateria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 124);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Clave de Materia";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(543, 160);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 260);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClaveMateria);
            Controls.Add(txtMateria);
            Name = "FrmMateria";
            Text = "FrmMateria";
            Load += FrmMateria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMateria;
        private TextBox txtClaveMateria;
        private Label label1;
        private Label label2;
        private Button btnAceptar;
    }
}