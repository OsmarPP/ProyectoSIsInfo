namespace ProyectoPapeletaPago
{
    partial class FormVistaAdministrador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGestionarPago = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGestionEMpleado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGestionEMpleado);
            this.groupBox1.Controls.Add(this.buttonGestionarPago);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // buttonGestionarPago
            // 
            this.buttonGestionarPago.Location = new System.Drawing.Point(7, 20);
            this.buttonGestionarPago.Name = "buttonGestionarPago";
            this.buttonGestionarPago.Size = new System.Drawing.Size(322, 23);
            this.buttonGestionarPago.TabIndex = 0;
            this.buttonGestionarPago.Text = "GESTIONAR PAGO";
            this.buttonGestionarPago.UseVisualStyleBackColor = true;
            this.buttonGestionarPago.Click += new System.EventHandler(this.buttonGestionarPago_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(374, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 505);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERFIL DEL ADMINISTRADOR";
            // 
            // buttonGestionEMpleado
            // 
            this.buttonGestionEMpleado.Location = new System.Drawing.Point(7, 72);
            this.buttonGestionEMpleado.Name = "buttonGestionEMpleado";
            this.buttonGestionEMpleado.Size = new System.Drawing.Size(322, 23);
            this.buttonGestionEMpleado.TabIndex = 1;
            this.buttonGestionEMpleado.Text = "GESTIONAR EMPLEADO";
            this.buttonGestionEMpleado.UseVisualStyleBackColor = true;
            this.buttonGestionEMpleado.Click += new System.EventHandler(this.buttonGestionEMpleado_Click);
            // 
            // FormVistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVistaAdministrador";
            this.Text = "FormVistaAdministrador";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGestionarPago;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGestionEMpleado;
    }
}