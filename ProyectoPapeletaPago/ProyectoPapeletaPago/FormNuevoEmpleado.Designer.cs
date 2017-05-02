namespace ProyectoPapeletaPago
{
    partial class FormNuevoEmpleado
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
            this.textBoxCi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProfesion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxAMaterno = new System.Windows.Forms.TextBox();
            this.textBoxSueldo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.textBoxAPaterno = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVistaPrevia = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCuentaBancaria = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCi
            // 
            this.textBoxCi.Location = new System.Drawing.Point(9, 57);
            this.textBoxCi.Name = "textBoxCi";
            this.textBoxCi.Size = new System.Drawing.Size(205, 20);
            this.textBoxCi.TabIndex = 0;
            this.textBoxCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCi_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCuentaBancaria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxRol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxProfesion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.textBoxCorreo);
            this.groupBox1.Controls.Add(this.textBoxAMaterno);
            this.groupBox1.Controls.Add(this.textBoxSueldo);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCargo);
            this.groupBox1.Controls.Add(this.textBoxAPaterno);
            this.groupBox1.Controls.Add(this.textBoxCi);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 609);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FORMULARIO DE REGISTRO DE EMPLEADO";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "administrador",
            "hora",
            "fijo"});
            this.comboBoxRol.Location = new System.Drawing.Point(9, 357);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(205, 21);
            this.comboBoxRol.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PROFESION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "CORREO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "APELLIDO MATERNO";
            // 
            // textBoxProfesion
            // 
            this.textBoxProfesion.Location = new System.Drawing.Point(9, 311);
            this.textBoxProfesion.Name = "textBoxProfesion";
            this.textBoxProfesion.Size = new System.Drawing.Size(205, 20);
            this.textBoxProfesion.TabIndex = 5;
            this.textBoxProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProfesion_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "SUELDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "TELEFONO";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(9, 261);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(205, 20);
            this.textBoxTelefono.TabIndex = 4;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(9, 509);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(205, 20);
            this.textBoxCorreo.TabIndex = 9;
            this.textBoxCorreo.Leave += new System.EventHandler(this.textBoxCorreo_Leave);
            // 
            // textBoxAMaterno
            // 
            this.textBoxAMaterno.Location = new System.Drawing.Point(9, 208);
            this.textBoxAMaterno.Name = "textBoxAMaterno";
            this.textBoxAMaterno.Size = new System.Drawing.Size(205, 20);
            this.textBoxAMaterno.TabIndex = 3;
            this.textBoxAMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAMaterno_KeyPress);
            // 
            // textBoxSueldo
            // 
            this.textBoxSueldo.Location = new System.Drawing.Point(9, 408);
            this.textBoxSueldo.Name = "textBoxSueldo";
            this.textBoxSueldo.Size = new System.Drawing.Size(205, 20);
            this.textBoxSueldo.TabIndex = 7;
            this.textBoxSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSueldo_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(9, 107);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(205, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "CARGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "APELLIDO PATERNO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "ROL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CI";
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(9, 459);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(205, 20);
            this.textBoxCargo.TabIndex = 8;
            this.textBoxCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCargo_KeyPress);
            // 
            // textBoxAPaterno
            // 
            this.textBoxAPaterno.Location = new System.Drawing.Point(9, 158);
            this.textBoxAPaterno.Name = "textBoxAPaterno";
            this.textBoxAPaterno.Size = new System.Drawing.Size(205, 20);
            this.textBoxAPaterno.TabIndex = 2;
            this.textBoxAPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAPaterno_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(248, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 666);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EMPLEADOS REGISTRADOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "REGISTRAR ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVistaPrevia
            // 
            this.buttonVistaPrevia.Location = new System.Drawing.Point(13, 657);
            this.buttonVistaPrevia.Name = "buttonVistaPrevia";
            this.buttonVistaPrevia.Size = new System.Drawing.Size(228, 23);
            this.buttonVistaPrevia.TabIndex = 10;
            this.buttonVistaPrevia.Text = "VISTA PREVIA DE REGISTRO";
            this.buttonVistaPrevia.UseVisualStyleBackColor = true;
            this.buttonVistaPrevia.Click += new System.EventHandler(this.buttonVistaPrevia_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "NUMERO DE CUENT BANCARIA";
            // 
            // textBoxCuentaBancaria
            // 
            this.textBoxCuentaBancaria.Location = new System.Drawing.Point(9, 563);
            this.textBoxCuentaBancaria.Name = "textBoxCuentaBancaria";
            this.textBoxCuentaBancaria.Size = new System.Drawing.Size(205, 20);
            this.textBoxCuentaBancaria.TabIndex = 24;
            this.textBoxCuentaBancaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCuentaBancaria_KeyPress);
            // 
            // FormNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 691);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonVistaPrevia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNuevoEmpleado";
            this.Text = "FormNuevoEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAMaterno;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAPaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProfesion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxSueldo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVistaPrevia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCuentaBancaria;
    }
}