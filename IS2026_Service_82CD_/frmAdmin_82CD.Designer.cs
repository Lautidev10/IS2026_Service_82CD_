namespace IS2026_Service_82CD_
{
    partial class frmAdmin_82CD
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
            this.lblTituloUsuarios_82CD = new System.Windows.Forms.Label();
            this.radbtnActivos_82CD = new System.Windows.Forms.RadioButton();
            this.radbtnTodos_82CD = new System.Windows.Forms.RadioButton();
            this.lblNUsuarios_82CD = new System.Windows.Forms.Label();
            this.DGUsuarios_82CD = new System.Windows.Forms.DataGridView();
            this.lblDNI_82CD = new System.Windows.Forms.Label();
            this.lblNombre_82CD = new System.Windows.Forms.Label();
            this.lblApellido_82CD = new System.Windows.Forms.Label();
            this.lblRol_82CD = new System.Windows.Forms.Label();
            this.lblNombreUsuario_82CD = new System.Windows.Forms.Label();
            this.lblTelefono_82CD = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnCrear_82CD = new System.Windows.Forms.Button();
            this.btnDesbloquear_82CD = new System.Windows.Forms.Button();
            this.btnModificar_82CD = new System.Windows.Forms.Button();
            this.btnActDesact_82CD = new System.Windows.Forms.Button();
            this.btnAplicar_82CD = new System.Windows.Forms.Button();
            this.btnCancelar_82CD = new System.Windows.Forms.Button();
            this.btnSalir_82CD = new System.Windows.Forms.Button();
            this.panFrmUsuario_82CD = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios_82CD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloUsuarios_82CD
            // 
            this.lblTituloUsuarios_82CD.AutoSize = true;
            this.lblTituloUsuarios_82CD.Font = new System.Drawing.Font("Montserrat Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuarios_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblTituloUsuarios_82CD.Location = new System.Drawing.Point(100, 55);
            this.lblTituloUsuarios_82CD.Name = "lblTituloUsuarios_82CD";
            this.lblTituloUsuarios_82CD.Size = new System.Drawing.Size(103, 22);
            this.lblTituloUsuarios_82CD.TabIndex = 0;
            this.lblTituloUsuarios_82CD.Text = "USUARIOS";
            // 
            // radbtnActivos_82CD
            // 
            this.radbtnActivos_82CD.AutoSize = true;
            this.radbtnActivos_82CD.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radbtnActivos_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.radbtnActivos_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.radbtnActivos_82CD.Location = new System.Drawing.Point(350, 55);
            this.radbtnActivos_82CD.Name = "radbtnActivos_82CD";
            this.radbtnActivos_82CD.Size = new System.Drawing.Size(52, 32);
            this.radbtnActivos_82CD.TabIndex = 1;
            this.radbtnActivos_82CD.TabStop = true;
            this.radbtnActivos_82CD.Text = "Activos";
            this.radbtnActivos_82CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radbtnActivos_82CD.UseVisualStyleBackColor = true;
            // 
            // radbtnTodos_82CD
            // 
            this.radbtnTodos_82CD.AutoSize = true;
            this.radbtnTodos_82CD.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radbtnTodos_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.radbtnTodos_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.radbtnTodos_82CD.Location = new System.Drawing.Point(450, 55);
            this.radbtnTodos_82CD.Name = "radbtnTodos_82CD";
            this.radbtnTodos_82CD.Size = new System.Drawing.Size(45, 32);
            this.radbtnTodos_82CD.TabIndex = 2;
            this.radbtnTodos_82CD.TabStop = true;
            this.radbtnTodos_82CD.Text = "Todos";
            this.radbtnTodos_82CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radbtnTodos_82CD.UseVisualStyleBackColor = true;
            // 
            // lblNUsuarios_82CD
            // 
            this.lblNUsuarios_82CD.AutoSize = true;
            this.lblNUsuarios_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNUsuarios_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblNUsuarios_82CD.Location = new System.Drawing.Point(600, 55);
            this.lblNUsuarios_82CD.Name = "lblNUsuarios_82CD";
            this.lblNUsuarios_82CD.Size = new System.Drawing.Size(134, 16);
            this.lblNUsuarios_82CD.TabIndex = 3;
            this.lblNUsuarios_82CD.Text = "Número de Usuarios:";
            // 
            // DGUsuarios_82CD
            // 
            this.DGUsuarios_82CD.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGUsuarios_82CD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios_82CD.Location = new System.Drawing.Point(100, 100);
            this.DGUsuarios_82CD.Name = "DGUsuarios_82CD";
            this.DGUsuarios_82CD.Size = new System.Drawing.Size(700, 200);
            this.DGUsuarios_82CD.TabIndex = 4;
            // 
            // lblDNI_82CD
            // 
            this.lblDNI_82CD.AutoSize = true;
            this.lblDNI_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDNI_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblDNI_82CD.Location = new System.Drawing.Point(100, 330);
            this.lblDNI_82CD.Name = "lblDNI_82CD";
            this.lblDNI_82CD.Size = new System.Drawing.Size(31, 16);
            this.lblDNI_82CD.TabIndex = 5;
            this.lblDNI_82CD.Text = "DNI";
            // 
            // lblNombre_82CD
            // 
            this.lblNombre_82CD.AutoSize = true;
            this.lblNombre_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblNombre_82CD.Location = new System.Drawing.Point(100, 365);
            this.lblNombre_82CD.Name = "lblNombre_82CD";
            this.lblNombre_82CD.Size = new System.Drawing.Size(58, 16);
            this.lblNombre_82CD.TabIndex = 6;
            this.lblNombre_82CD.Text = "Nombre";
            // 
            // lblApellido_82CD
            // 
            this.lblApellido_82CD.AutoSize = true;
            this.lblApellido_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellido_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblApellido_82CD.Location = new System.Drawing.Point(100, 400);
            this.lblApellido_82CD.Name = "lblApellido_82CD";
            this.lblApellido_82CD.Size = new System.Drawing.Size(56, 16);
            this.lblApellido_82CD.TabIndex = 7;
            this.lblApellido_82CD.Text = "Apellido";
            // 
            // lblRol_82CD
            // 
            this.lblRol_82CD.AutoSize = true;
            this.lblRol_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblRol_82CD.Location = new System.Drawing.Point(100, 435);
            this.lblRol_82CD.Name = "lblRol_82CD";
            this.lblRol_82CD.Size = new System.Drawing.Size(27, 16);
            this.lblRol_82CD.TabIndex = 8;
            this.lblRol_82CD.Text = "Rol";
            // 
            // lblNombreUsuario_82CD
            // 
            this.lblNombreUsuario_82CD.AutoSize = true;
            this.lblNombreUsuario_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblNombreUsuario_82CD.Location = new System.Drawing.Point(100, 470);
            this.lblNombreUsuario_82CD.Name = "lblNombreUsuario_82CD";
            this.lblNombreUsuario_82CD.Size = new System.Drawing.Size(53, 16);
            this.lblNombreUsuario_82CD.TabIndex = 9;
            this.lblNombreUsuario_82CD.Text = "Usuario";
            // 
            // lblTelefono_82CD
            // 
            this.lblTelefono_82CD.AutoSize = true;
            this.lblTelefono_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblTelefono_82CD.Location = new System.Drawing.Point(100, 505);
            this.lblTelefono_82CD.Name = "lblTelefono_82CD";
            this.lblTelefono_82CD.Size = new System.Drawing.Size(58, 16);
            this.lblTelefono_82CD.TabIndex = 10;
            this.lblTelefono_82CD.Text = "Telefono";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.textBox1.Location = new System.Drawing.Point(198, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.textBox2.Location = new System.Drawing.Point(198, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.textBox3.Location = new System.Drawing.Point(198, 400);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.textBox4.Location = new System.Drawing.Point(198, 435);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.textBox5.Location = new System.Drawing.Point(198, 470);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.textBox6.Location = new System.Drawing.Point(198, 505);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 20);
            this.textBox6.TabIndex = 16;
            // 
            // btnCrear_82CD
            // 
            this.btnCrear_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnCrear_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCrear_82CD.ForeColor = System.Drawing.Color.White;
            this.btnCrear_82CD.Location = new System.Drawing.Point(840, 100);
            this.btnCrear_82CD.Name = "btnCrear_82CD";
            this.btnCrear_82CD.Size = new System.Drawing.Size(115, 40);
            this.btnCrear_82CD.TabIndex = 17;
            this.btnCrear_82CD.Text = "Crear";
            this.btnCrear_82CD.UseVisualStyleBackColor = false;
            // 
            // btnDesbloquear_82CD
            // 
            this.btnDesbloquear_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnDesbloquear_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDesbloquear_82CD.ForeColor = System.Drawing.Color.White;
            this.btnDesbloquear_82CD.Location = new System.Drawing.Point(840, 165);
            this.btnDesbloquear_82CD.Name = "btnDesbloquear_82CD";
            this.btnDesbloquear_82CD.Size = new System.Drawing.Size(115, 40);
            this.btnDesbloquear_82CD.TabIndex = 18;
            this.btnDesbloquear_82CD.Text = "Desbloquear";
            this.btnDesbloquear_82CD.UseVisualStyleBackColor = false;
            // 
            // btnModificar_82CD
            // 
            this.btnModificar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnModificar_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnModificar_82CD.Location = new System.Drawing.Point(840, 230);
            this.btnModificar_82CD.Name = "btnModificar_82CD";
            this.btnModificar_82CD.Size = new System.Drawing.Size(115, 40);
            this.btnModificar_82CD.TabIndex = 19;
            this.btnModificar_82CD.Text = "Modificar";
            this.btnModificar_82CD.UseVisualStyleBackColor = false;
            // 
            // btnActDesact_82CD
            // 
            this.btnActDesact_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnActDesact_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnActDesact_82CD.ForeColor = System.Drawing.Color.White;
            this.btnActDesact_82CD.Location = new System.Drawing.Point(840, 295);
            this.btnActDesact_82CD.Name = "btnActDesact_82CD";
            this.btnActDesact_82CD.Size = new System.Drawing.Size(115, 40);
            this.btnActDesact_82CD.TabIndex = 20;
            this.btnActDesact_82CD.Text = "Act / Desact.";
            this.btnActDesact_82CD.UseVisualStyleBackColor = false;
            // 
            // btnAplicar_82CD
            // 
            this.btnAplicar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnAplicar_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAplicar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnAplicar_82CD.Location = new System.Drawing.Point(840, 360);
            this.btnAplicar_82CD.Name = "btnAplicar_82CD";
            this.btnAplicar_82CD.Size = new System.Drawing.Size(115, 40);
            this.btnAplicar_82CD.TabIndex = 21;
            this.btnAplicar_82CD.Text = "Aplicar";
            this.btnAplicar_82CD.UseVisualStyleBackColor = false;
            // 
            // btnCancelar_82CD
            // 
            this.btnCancelar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnCancelar_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnCancelar_82CD.Location = new System.Drawing.Point(840, 425);
            this.btnCancelar_82CD.Name = "btnCancelar_82CD";
            this.btnCancelar_82CD.Size = new System.Drawing.Size(115, 40);
            this.btnCancelar_82CD.TabIndex = 22;
            this.btnCancelar_82CD.Text = "Cancelar";
            this.btnCancelar_82CD.UseVisualStyleBackColor = false;
            // 
            // btnSalir_82CD
            // 
            this.btnSalir_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnSalir_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir_82CD.ForeColor = System.Drawing.Color.White;
            this.btnSalir_82CD.Location = new System.Drawing.Point(840, 490);
            this.btnSalir_82CD.Name = "btnSalir_82CD";
            this.btnSalir_82CD.Size = new System.Drawing.Size(115, 40);
            this.btnSalir_82CD.TabIndex = 23;
            this.btnSalir_82CD.Text = "Salir";
            this.btnSalir_82CD.UseVisualStyleBackColor = false;
            // 
            // panFrmUsuario_82CD
            // 
            this.panFrmUsuario_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.panFrmUsuario_82CD.Location = new System.Drawing.Point(-1, 0);
            this.panFrmUsuario_82CD.Name = "panFrmUsuario_82CD";
            this.panFrmUsuario_82CD.Size = new System.Drawing.Size(985, 40);
            this.panFrmUsuario_82CD.TabIndex = 24;
            // 
            // frmAdmin_82CD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panFrmUsuario_82CD);
            this.Controls.Add(this.btnSalir_82CD);
            this.Controls.Add(this.btnCancelar_82CD);
            this.Controls.Add(this.btnAplicar_82CD);
            this.Controls.Add(this.btnActDesact_82CD);
            this.Controls.Add(this.btnModificar_82CD);
            this.Controls.Add(this.btnDesbloquear_82CD);
            this.Controls.Add(this.btnCrear_82CD);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTelefono_82CD);
            this.Controls.Add(this.lblNombreUsuario_82CD);
            this.Controls.Add(this.lblRol_82CD);
            this.Controls.Add(this.lblApellido_82CD);
            this.Controls.Add(this.lblNombre_82CD);
            this.Controls.Add(this.lblDNI_82CD);
            this.Controls.Add(this.DGUsuarios_82CD);
            this.Controls.Add(this.lblNUsuarios_82CD);
            this.Controls.Add(this.radbtnTodos_82CD);
            this.Controls.Add(this.radbtnActivos_82CD);
            this.Controls.Add(this.lblTituloUsuarios_82CD);
            this.Name = "frmAdmin_82CD";
            this.Text = "frmUsuarios_82CD";
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios_82CD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloUsuarios_82CD;
        private System.Windows.Forms.RadioButton radbtnActivos_82CD;
        private System.Windows.Forms.RadioButton radbtnTodos_82CD;
        private System.Windows.Forms.Label lblNUsuarios_82CD;
        private System.Windows.Forms.DataGridView DGUsuarios_82CD;
        private System.Windows.Forms.Label lblDNI_82CD;
        private System.Windows.Forms.Label lblNombre_82CD;
        private System.Windows.Forms.Label lblApellido_82CD;
        private System.Windows.Forms.Label lblRol_82CD;
        private System.Windows.Forms.Label lblNombreUsuario_82CD;
        private System.Windows.Forms.Label lblTelefono_82CD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnCrear_82CD;
        private System.Windows.Forms.Button btnDesbloquear_82CD;
        private System.Windows.Forms.Button btnModificar_82CD;
        private System.Windows.Forms.Button btnActDesact_82CD;
        private System.Windows.Forms.Button btnAplicar_82CD;
        private System.Windows.Forms.Button btnCancelar_82CD;
        private System.Windows.Forms.Button btnSalir_82CD;
        private System.Windows.Forms.Panel panFrmUsuario_82CD;
    }
}