namespace Cajero
{
    partial class Acciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonRetiro = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupConsulta = new System.Windows.Forms.GroupBox();
            this.buttonSalirConsulta = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.label_saldo = new System.Windows.Forms.Label();
            this.label_tipoCuenta = new System.Windows.Forms.Label();
            this.label_cuenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxRetirar = new System.Windows.Forms.GroupBox();
            this.buttonSalirRetirar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.groupConsulta.SuspendLayout();
            this.groupBoxRetirar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buen día  ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(148, 36);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(89, 33);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "label2";
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(18, 98);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(75, 23);
            this.buttonConsulta.TabIndex = 2;
            this.buttonConsulta.Text = "Consulta";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRetiro
            // 
            this.buttonRetiro.Location = new System.Drawing.Point(18, 159);
            this.buttonRetiro.Name = "buttonRetiro";
            this.buttonRetiro.Size = new System.Drawing.Size(75, 23);
            this.buttonRetiro.TabIndex = 3;
            this.buttonRetiro.Text = "Retiro";
            this.buttonRetiro.UseVisualStyleBackColor = true;
            this.buttonRetiro.Click += new System.EventHandler(this.buttonRetiro_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(18, 217);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // groupConsulta
            // 
            this.groupConsulta.Controls.Add(this.buttonSalirConsulta);
            this.groupConsulta.Controls.Add(this.buttonVolver);
            this.groupConsulta.Controls.Add(this.label_saldo);
            this.groupConsulta.Controls.Add(this.label_tipoCuenta);
            this.groupConsulta.Controls.Add(this.label_cuenta);
            this.groupConsulta.Controls.Add(this.label4);
            this.groupConsulta.Controls.Add(this.label3);
            this.groupConsulta.Controls.Add(this.label2);
            this.groupConsulta.Controls.Add(this.label5);
            this.groupConsulta.Location = new System.Drawing.Point(18, 88);
            this.groupConsulta.Name = "groupConsulta";
            this.groupConsulta.Size = new System.Drawing.Size(486, 208);
            this.groupConsulta.TabIndex = 5;
            this.groupConsulta.TabStop = false;
            // 
            // buttonSalirConsulta
            // 
            this.buttonSalirConsulta.Location = new System.Drawing.Point(383, 170);
            this.buttonSalirConsulta.Name = "buttonSalirConsulta";
            this.buttonSalirConsulta.Size = new System.Drawing.Size(75, 23);
            this.buttonSalirConsulta.TabIndex = 15;
            this.buttonSalirConsulta.Text = "Salir";
            this.buttonSalirConsulta.UseVisualStyleBackColor = true;
            this.buttonSalirConsulta.Click += new System.EventHandler(this.buttonSalirConsulta_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(9, 170);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 14;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // label_saldo
            // 
            this.label_saldo.AutoSize = true;
            this.label_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saldo.Location = new System.Drawing.Point(137, 125);
            this.label_saldo.Name = "label_saldo";
            this.label_saldo.Size = new System.Drawing.Size(60, 24);
            this.label_saldo.TabIndex = 13;
            this.label_saldo.Text = "label7";
            // 
            // label_tipoCuenta
            // 
            this.label_tipoCuenta.AutoSize = true;
            this.label_tipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipoCuenta.Location = new System.Drawing.Point(137, 85);
            this.label_tipoCuenta.Name = "label_tipoCuenta";
            this.label_tipoCuenta.Size = new System.Drawing.Size(60, 24);
            this.label_tipoCuenta.TabIndex = 12;
            this.label_tipoCuenta.Text = "label6";
            // 
            // label_cuenta
            // 
            this.label_cuenta.AutoSize = true;
            this.label_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuenta.Location = new System.Drawing.Point(137, 44);
            this.label_cuenta.Name = "label_cuenta";
            this.label_cuenta.Size = new System.Drawing.Size(60, 24);
            this.label_cuenta.TabIndex = 11;
            this.label_cuenta.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cuenta: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "El saldo de su cuenta es de:";
            // 
            // groupBoxRetirar
            // 
            this.groupBoxRetirar.Controls.Add(this.textBoxValor);
            this.groupBoxRetirar.Controls.Add(this.buttonSalirRetirar);
            this.groupBoxRetirar.Controls.Add(this.buttonAceptar);
            this.groupBoxRetirar.Controls.Add(this.label11);
            this.groupBoxRetirar.Location = new System.Drawing.Point(18, 88);
            this.groupBoxRetirar.Name = "groupBoxRetirar";
            this.groupBoxRetirar.Size = new System.Drawing.Size(486, 208);
            this.groupBoxRetirar.TabIndex = 16;
            this.groupBoxRetirar.TabStop = false;
            // 
            // buttonSalirRetirar
            // 
            this.buttonSalirRetirar.Location = new System.Drawing.Point(383, 170);
            this.buttonSalirRetirar.Name = "buttonSalirRetirar";
            this.buttonSalirRetirar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalirRetirar.TabIndex = 15;
            this.buttonSalirRetirar.Text = "Salir";
            this.buttonSalirRetirar.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(9, 170);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cuenta: ";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(151, 49);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 16;
            // 
            // Acciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 308);
            this.Controls.Add(this.groupBoxRetirar);
            this.Controls.Add(this.groupConsulta);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRetiro);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Name = "Acciones";
            this.Text = "Acciones";
            this.Load += new System.EventHandler(this.Acciones_Load);
            this.groupConsulta.ResumeLayout(false);
            this.groupConsulta.PerformLayout();
            this.groupBoxRetirar.ResumeLayout(false);
            this.groupBoxRetirar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.Button buttonRetiro;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.GroupBox groupConsulta;
        private System.Windows.Forms.Label label_saldo;
        private System.Windows.Forms.Label label_tipoCuenta;
        private System.Windows.Forms.Label label_cuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSalirConsulta;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox groupBoxRetirar;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonSalirRetirar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label11;
    }
}