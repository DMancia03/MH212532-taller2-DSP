
namespace MH212532_taller2
{
    partial class dashboardCuenta
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
            this.lbEslogan = new System.Windows.Forms.Label();
            this.lbTitleBank = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lbSaldoActual = new System.Windows.Forms.Label();
            this.txtSueldoActual = new System.Windows.Forms.TextBox();
            this.lbTransacciones = new System.Windows.Forms.Label();
            this.lstTransacciones = new System.Windows.Forms.ListBox();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnCerrarCuenta = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEslogan
            // 
            this.lbEslogan.AutoSize = true;
            this.lbEslogan.Location = new System.Drawing.Point(139, 69);
            this.lbEslogan.Name = "lbEslogan";
            this.lbEslogan.Size = new System.Drawing.Size(247, 28);
            this.lbEslogan.TabIndex = 5;
            this.lbEslogan.Text = "\"Confía en nuestra lealtad.\"";
            // 
            // lbTitleBank
            // 
            this.lbTitleBank.AutoSize = true;
            this.lbTitleBank.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleBank.Location = new System.Drawing.Point(136, 12);
            this.lbTitleBank.Name = "lbTitleBank";
            this.lbTitleBank.Size = new System.Drawing.Size(292, 48);
            this.lbTitleBank.TabIndex = 4;
            this.lbTitleBank.Text = "Banco \"El Leal\"";
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::MH212532_taller2.Properties.Resources.bank;
            this.ptbLogo.Location = new System.Drawing.Point(12, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(118, 112);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 3;
            this.ptbLogo.TabStop = false;
            // 
            // lbSaldoActual
            // 
            this.lbSaldoActual.AutoSize = true;
            this.lbSaldoActual.Location = new System.Drawing.Point(12, 148);
            this.lbSaldoActual.Name = "lbSaldoActual";
            this.lbSaldoActual.Size = new System.Drawing.Size(122, 28);
            this.lbSaldoActual.TabIndex = 6;
            this.lbSaldoActual.Text = "Saldo Actual";
            // 
            // txtSueldoActual
            // 
            this.txtSueldoActual.Location = new System.Drawing.Point(17, 180);
            this.txtSueldoActual.Name = "txtSueldoActual";
            this.txtSueldoActual.ReadOnly = true;
            this.txtSueldoActual.Size = new System.Drawing.Size(404, 34);
            this.txtSueldoActual.TabIndex = 7;
            // 
            // lbTransacciones
            // 
            this.lbTransacciones.AutoSize = true;
            this.lbTransacciones.Location = new System.Drawing.Point(17, 238);
            this.lbTransacciones.Name = "lbTransacciones";
            this.lbTransacciones.Size = new System.Drawing.Size(134, 28);
            this.lbTransacciones.TabIndex = 8;
            this.lbTransacciones.Text = "Transacciones:";
            // 
            // lstTransacciones
            // 
            this.lstTransacciones.FormattingEnabled = true;
            this.lstTransacciones.ItemHeight = 28;
            this.lstTransacciones.Location = new System.Drawing.Point(17, 269);
            this.lstTransacciones.Name = "lstTransacciones";
            this.lstTransacciones.Size = new System.Drawing.Size(404, 144);
            this.lstTransacciones.TabIndex = 10;
            // 
            // btnAbonar
            // 
            this.btnAbonar.Location = new System.Drawing.Point(17, 434);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(130, 78);
            this.btnAbonar.TabIndex = 11;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(155, 434);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(130, 78);
            this.btnRetirar.TabIndex = 12;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.Location = new System.Drawing.Point(291, 434);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.Size = new System.Drawing.Size(130, 78);
            this.btnCerrarCuenta.TabIndex = 13;
            this.btnCerrarCuenta.Text = "Cerrar Cuenta";
            this.btnCerrarCuenta.UseVisualStyleBackColor = true;
            this.btnCerrarCuenta.Click += new System.EventHandler(this.btnCerrarCuenta_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 605);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(190, 78);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(231, 605);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(190, 78);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar Aplicación";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 521);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(409, 78);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Ver mis datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dashboardCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(433, 695);
            this.ControlBox = false;
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCerrarCuenta);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.lstTransacciones);
            this.Controls.Add(this.lbTransacciones);
            this.Controls.Add(this.txtSueldoActual);
            this.Controls.Add(this.lbSaldoActual);
            this.Controls.Add(this.lbEslogan);
            this.Controls.Add(this.lbTitleBank);
            this.Controls.Add(this.ptbLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dashboardCuenta";
            this.Text = "dashboardCuenta";
            this.Load += new System.EventHandler(this.dashboardCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEslogan;
        private System.Windows.Forms.Label lbTitleBank;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lbSaldoActual;
        private System.Windows.Forms.TextBox txtSueldoActual;
        private System.Windows.Forms.Label lbTransacciones;
        private System.Windows.Forms.ListBox lstTransacciones;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnCerrarCuenta;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMostrar;
    }
}