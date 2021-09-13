
namespace MH212532_taller2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lbTitleBank = new System.Windows.Forms.Label();
            this.lbEslogan = new System.Windows.Forms.Label();
            this.lbTitleLogin = new System.Windows.Forms.Label();
            this.lbCuentaBancaria = new System.Windows.Forms.Label();
            this.lbDUI = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::MH212532_taller2.Properties.Resources.bank;
            this.ptbLogo.Location = new System.Drawing.Point(12, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(118, 112);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // lbTitleBank
            // 
            this.lbTitleBank.AutoSize = true;
            this.lbTitleBank.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleBank.Location = new System.Drawing.Point(136, 12);
            this.lbTitleBank.Name = "lbTitleBank";
            this.lbTitleBank.Size = new System.Drawing.Size(292, 48);
            this.lbTitleBank.TabIndex = 1;
            this.lbTitleBank.Text = "Banco \"El Leal\"";
            // 
            // lbEslogan
            // 
            this.lbEslogan.AutoSize = true;
            this.lbEslogan.Location = new System.Drawing.Point(139, 69);
            this.lbEslogan.Name = "lbEslogan";
            this.lbEslogan.Size = new System.Drawing.Size(247, 28);
            this.lbEslogan.TabIndex = 2;
            this.lbEslogan.Text = "\"Confía en nuestra lealtad.\"";
            // 
            // lbTitleLogin
            // 
            this.lbTitleLogin.AutoSize = true;
            this.lbTitleLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleLogin.Location = new System.Drawing.Point(10, 149);
            this.lbTitleLogin.Name = "lbTitleLogin";
            this.lbTitleLogin.Size = new System.Drawing.Size(313, 38);
            this.lbTitleLogin.TabIndex = 3;
            this.lbTitleLogin.Text = "Ingresa tus credenciales";
            // 
            // lbCuentaBancaria
            // 
            this.lbCuentaBancaria.AutoSize = true;
            this.lbCuentaBancaria.Location = new System.Drawing.Point(7, 203);
            this.lbCuentaBancaria.Name = "lbCuentaBancaria";
            this.lbCuentaBancaria.Size = new System.Drawing.Size(178, 28);
            this.lbCuentaBancaria.TabIndex = 4;
            this.lbCuentaBancaria.Text = "Número de cuenta:";
            // 
            // lbDUI
            // 
            this.lbDUI.AutoSize = true;
            this.lbDUI.Location = new System.Drawing.Point(12, 250);
            this.lbDUI.Name = "lbDUI";
            this.lbDUI.Size = new System.Drawing.Size(49, 28);
            this.lbDUI.TabIndex = 5;
            this.lbDUI.Text = "DUI:";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(191, 203);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(230, 34);
            this.txtNumeroCuenta.TabIndex = 6;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(191, 247);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(230, 34);
            this.txtDUI.TabIndex = 7;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Location = new System.Drawing.Point(12, 296);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(194, 76);
            this.btnLogIn.TabIndex = 9;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(227, 297);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(194, 76);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar Aplicación";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(433, 385);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.lbDUI);
            this.Controls.Add(this.lbCuentaBancaria);
            this.Controls.Add(this.lbTitleLogin);
            this.Controls.Add(this.lbEslogan);
            this.Controls.Add(this.lbTitleBank);
            this.Controls.Add(this.ptbLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lbTitleBank;
        private System.Windows.Forms.Label lbEslogan;
        private System.Windows.Forms.Label lbTitleLogin;
        private System.Windows.Forms.Label lbCuentaBancaria;
        private System.Windows.Forms.Label lbDUI;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCerrar;
    }
}

