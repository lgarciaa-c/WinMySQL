namespace WINMYSQL.VISTAS
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
            txtAlumno = new TextBox();
            txtNumControl = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 132);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Num. Control";
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(41, 57);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(483, 27);
            txtAlumno.TabIndex = 2;
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(41, 170);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(483, 27);
            txtNumControl.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(576, 166);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(106, 35);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 239);
            Controls.Add(btnAceptar);
            Controls.Add(txtNumControl);
            Controls.Add(txtAlumno);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAlumno";
            Text = "FrmAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAlumno;
        private TextBox txtNumControl;
        private Button btnAceptar;
    }
}