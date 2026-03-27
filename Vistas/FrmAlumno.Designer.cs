namespace WinMySQL.Vistas
{
    partial class FrmAlumno
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            txtMaterno = new TextBox();
            label4 = new Label();
            txtNumeroControl = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 10);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 9);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(19, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(235, 28);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(184, 23);
            txtPaterno.TabIndex = 4;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(454, 27);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(184, 23);
            txtMaterno.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 71);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 6;
            label4.Text = "Numero de Control";
            // 
            // txtNumeroControl
            // 
            txtNumeroControl.Location = new Point(19, 89);
            txtNumeroControl.Name = "txtNumeroControl";
            txtNumeroControl.Size = new Size(184, 23);
            txtNumeroControl.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(290, 132);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(662, 181);
            Controls.Add(btnAceptar);
            Controls.Add(txtNumeroControl);
            Controls.Add(label4);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAlumno";
            Text = "Agregar Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private TextBox txtMaterno;
        private Label label4;
        private TextBox txtNumeroControl;
        private Button btnAceptar;
    }
}