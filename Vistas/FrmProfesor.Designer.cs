namespace WINMYSQL.VISTAS
{
    partial class FrmProfesor
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
            txtProfesor = new TextBox();
            txtClave = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Profesor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 149);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Clave";
            // 
            // txtProfesor
            // 
            txtProfesor.Location = new Point(57, 87);
            txtProfesor.Name = "txtProfesor";
            txtProfesor.Size = new Size(568, 27);
            txtProfesor.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(57, 186);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(568, 27);
            txtClave.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(656, 186);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 252);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(txtProfesor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProfesor";
            Text = "FrmProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProfesor;
        private TextBox txtClave;
        private Button btnAceptar;
    }
}