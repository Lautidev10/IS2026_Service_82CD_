namespace IS2026_Service_82CD_
{
    partial class frmLogin_82CD
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
            this.txtUsuario_82CD = new System.Windows.Forms.TextBox();
            this.txtContraseña_82CD = new System.Windows.Forms.TextBox();
            this.lblUsuario_82CD = new System.Windows.Forms.Label();
            this.lblContraseña_82CD = new System.Windows.Forms.Label();
            this.btnIniciarSesion_82CD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario_82CD
            // 
            this.txtUsuario_82CD.Location = new System.Drawing.Point(184, 31);
            this.txtUsuario_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario_82CD.Name = "txtUsuario_82CD";
            this.txtUsuario_82CD.Size = new System.Drawing.Size(208, 22);
            this.txtUsuario_82CD.TabIndex = 0;
            // 
            // txtContraseña_82CD
            // 
            this.txtContraseña_82CD.Location = new System.Drawing.Point(184, 89);
            this.txtContraseña_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña_82CD.Name = "txtContraseña_82CD";
            this.txtContraseña_82CD.PasswordChar = '*';
            this.txtContraseña_82CD.Size = new System.Drawing.Size(208, 22);
            this.txtContraseña_82CD.TabIndex = 1;
            // 
            // lblUsuario_82CD
            // 
            this.lblUsuario_82CD.AutoSize = true;
            this.lblUsuario_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblUsuario_82CD.Location = new System.Drawing.Point(75, 34);
            this.lblUsuario_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario_82CD.Name = "lblUsuario_82CD";
            this.lblUsuario_82CD.Size = new System.Drawing.Size(67, 18);
            this.lblUsuario_82CD.TabIndex = 2;
            this.lblUsuario_82CD.Text = "Usuario";
            // 
            // lblContraseña_82CD
            // 
            this.lblContraseña_82CD.AutoSize = true;
            this.lblContraseña_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblContraseña_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblContraseña_82CD.Location = new System.Drawing.Point(63, 92);
            this.lblContraseña_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña_82CD.Name = "lblContraseña_82CD";
            this.lblContraseña_82CD.Size = new System.Drawing.Size(95, 18);
            this.lblContraseña_82CD.TabIndex = 3;
            this.lblContraseña_82CD.Text = "Contraseña";
            // 
            // btnIniciarSesion_82CD
            // 
            this.btnIniciarSesion_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnIniciarSesion_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion_82CD.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion_82CD.Location = new System.Drawing.Point(133, 160);
            this.btnIniciarSesion_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarSesion_82CD.Name = "btnIniciarSesion_82CD";
            this.btnIniciarSesion_82CD.Size = new System.Drawing.Size(169, 43);
            this.btnIniciarSesion_82CD.TabIndex = 4;
            this.btnIniciarSesion_82CD.Text = "Iniciar Sesion";
            this.btnIniciarSesion_82CD.UseVisualStyleBackColor = false;
            this.btnIniciarSesion_82CD.Click += new System.EventHandler(this.btnIniciarSesion_82CD_Click);
            // 
            // frmLogin_82CD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 257);
            this.Controls.Add(this.btnIniciarSesion_82CD);
            this.Controls.Add(this.lblContraseña_82CD);
            this.Controls.Add(this.lblUsuario_82CD);
            this.Controls.Add(this.txtContraseña_82CD);
            this.Controls.Add(this.txtUsuario_82CD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin_82CD";
            this.Text = "FrmLogin_82CD";
            this.Load += new System.EventHandler(this.frmLogin_82CD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario_82CD;
        private System.Windows.Forms.TextBox txtContraseña_82CD;
        private System.Windows.Forms.Label lblUsuario_82CD;
        private System.Windows.Forms.Label lblContraseña_82CD;
        private System.Windows.Forms.Button btnIniciarSesion_82CD;
    }
}

