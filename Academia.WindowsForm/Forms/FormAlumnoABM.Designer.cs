namespace Academia.WindowsForms.Forms
{
    partial class FormAlumnoABM
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
            txtBoxNombre = new TextBox();
            txtBoxApellido = new TextBox();
            txtBoxDNI = new TextBox();
            btnGuardar = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblFechaNac = new Label();
            dTPFechaNac = new DateTimePicker();
            SuspendLayout();
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(40, 61);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(276, 27);
            txtBoxNombre.TabIndex = 0;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(40, 136);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(276, 27);
            txtBoxApellido.TabIndex = 1;
            // 
            // txtBoxDNI
            // 
            txtBoxDNI.ForeColor = SystemColors.WindowText;
            txtBoxDNI.Location = new Point(40, 212);
            txtBoxDNI.Name = "txtBoxDNI";
            txtBoxDNI.Size = new Size(276, 27);
            txtBoxDNI.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(40, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.WindowText;
            lblNombre.Location = new Point(40, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(40, 113);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(40, 189);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(42, 20);
            lblDNI.TabIndex = 6;
            lblDNI.Text = "DNI: ";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(40, 265);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(152, 20);
            lblFechaNac.TabIndex = 8;
            lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // dTPFechaNac
            // 
            dTPFechaNac.Location = new Point(40, 288);
            dTPFechaNac.Name = "dTPFechaNac";
            dTPFechaNac.Size = new Size(276, 27);
            dTPFechaNac.TabIndex = 9;
            // 
            // FormAlumnoABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(dTPFechaNac);
            Controls.Add(lblFechaNac);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            Controls.Add(txtBoxDNI);
            Controls.Add(txtBoxApellido);
            Controls.Add(txtBoxNombre);
            Name = "FormAlumnoABM";
            Text = "FormAlumnoABM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNombre;
        private TextBox txtBoxApellido;
        private TextBox txtBoxDNI;
        private Button btnGuardar;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblFechaNac;
        private DateTimePicker dTPFechaNac;
    }
}