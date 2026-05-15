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
            this.lblApellidos_82CD = new System.Windows.Forms.Label();
            this.lblRol_82CD = new System.Windows.Forms.Label();
            this.lblLogin_82CD = new System.Windows.Forms.Label();
            this.lblEmail_82CD = new System.Windows.Forms.Label();
            this.txtDNI_82CD = new System.Windows.Forms.TextBox();
            this.txtApellidos_82CD = new System.Windows.Forms.TextBox();
            this.txtNombre_82CD = new System.Windows.Forms.TextBox();
            this.txtLogin_82CD = new System.Windows.Forms.TextBox();
            this.txtEmail_82CD = new System.Windows.Forms.TextBox();
            this.btnCrear_82CD = new System.Windows.Forms.Button();
            this.btnDesbloquear_82CD = new System.Windows.Forms.Button();
            this.btnModificar_82CD = new System.Windows.Forms.Button();
            this.btnActDesact_82CD = new System.Windows.Forms.Button();
            this.btnAplicar_82CD = new System.Windows.Forms.Button();
            this.btnCancelar_82CD = new System.Windows.Forms.Button();
            this.btnSalir_82CD = new System.Windows.Forms.Button();
            this.panFrmUsuario_82CD = new System.Windows.Forms.Panel();
            this.lblBloqueado_82CD = new System.Windows.Forms.Label();
            this.lblActivo_82CD = new System.Windows.Forms.Label();
            this.cmbRol_82CD = new System.Windows.Forms.ComboBox();
            this.rtbMensaje_82CD = new System.Windows.Forms.RichTextBox();
            this.lclCantUsuarios_82CD = new System.Windows.Forms.Label();
            this.txtBloqueado_82CD = new System.Windows.Forms.TextBox();
            this.txtActivo_82CD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios_82CD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloUsuarios_82CD
            // 
            this.lblTituloUsuarios_82CD.AutoSize = true;
            this.lblTituloUsuarios_82CD.Font = new System.Drawing.Font("Montserrat Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuarios_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblTituloUsuarios_82CD.Location = new System.Drawing.Point(133, 68);
            this.lblTituloUsuarios_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloUsuarios_82CD.Name = "lblTituloUsuarios_82CD";
            this.lblTituloUsuarios_82CD.Size = new System.Drawing.Size(125, 27);
            this.lblTituloUsuarios_82CD.TabIndex = 0;
            this.lblTituloUsuarios_82CD.Text = "USUARIOS";
            // 
            // radbtnActivos_82CD
            // 
            this.radbtnActivos_82CD.AutoSize = true;
            this.radbtnActivos_82CD.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radbtnActivos_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.radbtnActivos_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.radbtnActivos_82CD.Location = new System.Drawing.Point(467, 68);
            this.radbtnActivos_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnActivos_82CD.Name = "radbtnActivos_82CD";
            this.radbtnActivos_82CD.Size = new System.Drawing.Size(65, 40);
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
            this.radbtnTodos_82CD.Location = new System.Drawing.Point(600, 68);
            this.radbtnTodos_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnTodos_82CD.Name = "radbtnTodos_82CD";
            this.radbtnTodos_82CD.Size = new System.Drawing.Size(55, 40);
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
            this.lblNUsuarios_82CD.Location = new System.Drawing.Point(800, 68);
            this.lblNUsuarios_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNUsuarios_82CD.Name = "lblNUsuarios_82CD";
            this.lblNUsuarios_82CD.Size = new System.Drawing.Size(171, 21);
            this.lblNUsuarios_82CD.TabIndex = 3;
            this.lblNUsuarios_82CD.Text = "Número de Usuarios:";
            // 
            // DGUsuarios_82CD
            // 
            this.DGUsuarios_82CD.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGUsuarios_82CD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios_82CD.Location = new System.Drawing.Point(133, 123);
            this.DGUsuarios_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.DGUsuarios_82CD.Name = "DGUsuarios_82CD";
            this.DGUsuarios_82CD.RowHeadersWidth = 51;
            this.DGUsuarios_82CD.Size = new System.Drawing.Size(933, 246);
            this.DGUsuarios_82CD.TabIndex = 4;
            this.DGUsuarios_82CD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUsuarios_82CD_CellClick);
            // 
            // lblDNI_82CD
            // 
            this.lblDNI_82CD.AutoSize = true;
            this.lblDNI_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDNI_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblDNI_82CD.Location = new System.Drawing.Point(135, 388);
            this.lblDNI_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI_82CD.Name = "lblDNI_82CD";
            this.lblDNI_82CD.Size = new System.Drawing.Size(39, 21);
            this.lblDNI_82CD.TabIndex = 5;
            this.lblDNI_82CD.Text = "DNI";
            // 
            // lblNombre_82CD
            // 
            this.lblNombre_82CD.AutoSize = true;
            this.lblNombre_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblNombre_82CD.Location = new System.Drawing.Point(135, 474);
            this.lblNombre_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre_82CD.Name = "lblNombre_82CD";
            this.lblNombre_82CD.Size = new System.Drawing.Size(73, 21);
            this.lblNombre_82CD.TabIndex = 6;
            this.lblNombre_82CD.Text = "Nombre";
            // 
            // lblApellidos_82CD
            // 
            this.lblApellidos_82CD.AutoSize = true;
            this.lblApellidos_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellidos_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblApellidos_82CD.Location = new System.Drawing.Point(135, 431);
            this.lblApellidos_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos_82CD.Name = "lblApellidos_82CD";
            this.lblApellidos_82CD.Size = new System.Drawing.Size(80, 21);
            this.lblApellidos_82CD.TabIndex = 7;
            this.lblApellidos_82CD.Text = "Apellidos";
            // 
            // lblRol_82CD
            // 
            this.lblRol_82CD.AutoSize = true;
            this.lblRol_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblRol_82CD.Location = new System.Drawing.Point(135, 558);
            this.lblRol_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol_82CD.Name = "lblRol_82CD";
            this.lblRol_82CD.Size = new System.Drawing.Size(35, 21);
            this.lblRol_82CD.TabIndex = 8;
            this.lblRol_82CD.Text = "Rol";
            // 
            // lblLogin_82CD
            // 
            this.lblLogin_82CD.AutoSize = true;
            this.lblLogin_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLogin_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblLogin_82CD.Location = new System.Drawing.Point(135, 603);
            this.lblLogin_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin_82CD.Name = "lblLogin_82CD";
            this.lblLogin_82CD.Size = new System.Drawing.Size(53, 21);
            this.lblLogin_82CD.TabIndex = 9;
            this.lblLogin_82CD.Text = "Login";
            // 
            // lblEmail_82CD
            // 
            this.lblEmail_82CD.AutoSize = true;
            this.lblEmail_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblEmail_82CD.Location = new System.Drawing.Point(135, 514);
            this.lblEmail_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail_82CD.Name = "lblEmail_82CD";
            this.lblEmail_82CD.Size = new System.Drawing.Size(53, 21);
            this.lblEmail_82CD.TabIndex = 10;
            this.lblEmail_82CD.Text = "Email";
            // 
            // txtDNI_82CD
            // 
            this.txtDNI_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.txtDNI_82CD.Location = new System.Drawing.Point(265, 388);
            this.txtDNI_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI_82CD.Name = "txtDNI_82CD";
            this.txtDNI_82CD.Size = new System.Drawing.Size(199, 22);
            this.txtDNI_82CD.TabIndex = 11;
            // 
            // txtApellidos_82CD
            // 
            this.txtApellidos_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.txtApellidos_82CD.Location = new System.Drawing.Point(265, 431);
            this.txtApellidos_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos_82CD.Name = "txtApellidos_82CD";
            this.txtApellidos_82CD.Size = new System.Drawing.Size(199, 22);
            this.txtApellidos_82CD.TabIndex = 12;
            // 
            // txtNombre_82CD
            // 
            this.txtNombre_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.txtNombre_82CD.Location = new System.Drawing.Point(265, 474);
            this.txtNombre_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre_82CD.Name = "txtNombre_82CD";
            this.txtNombre_82CD.Size = new System.Drawing.Size(199, 22);
            this.txtNombre_82CD.TabIndex = 13;
            // 
            // txtLogin_82CD
            // 
            this.txtLogin_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.txtLogin_82CD.Location = new System.Drawing.Point(265, 603);
            this.txtLogin_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin_82CD.Name = "txtLogin_82CD";
            this.txtLogin_82CD.Size = new System.Drawing.Size(199, 22);
            this.txtLogin_82CD.TabIndex = 15;
            // 
            // txtEmail_82CD
            // 
            this.txtEmail_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.txtEmail_82CD.Location = new System.Drawing.Point(265, 514);
            this.txtEmail_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail_82CD.Name = "txtEmail_82CD";
            this.txtEmail_82CD.Size = new System.Drawing.Size(199, 22);
            this.txtEmail_82CD.TabIndex = 16;
            // 
            // btnCrear_82CD
            // 
            this.btnCrear_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnCrear_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCrear_82CD.ForeColor = System.Drawing.Color.White;
            this.btnCrear_82CD.Location = new System.Drawing.Point(1120, 123);
            this.btnCrear_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear_82CD.Name = "btnCrear_82CD";
            this.btnCrear_82CD.Size = new System.Drawing.Size(153, 49);
            this.btnCrear_82CD.TabIndex = 17;
            this.btnCrear_82CD.Text = "Crear";
            this.btnCrear_82CD.UseVisualStyleBackColor = false;
            this.btnCrear_82CD.Click += new System.EventHandler(this.btnCrear_82CD_Click);
            // 
            // btnDesbloquear_82CD
            // 
            this.btnDesbloquear_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnDesbloquear_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDesbloquear_82CD.ForeColor = System.Drawing.Color.White;
            this.btnDesbloquear_82CD.Location = new System.Drawing.Point(1120, 203);
            this.btnDesbloquear_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesbloquear_82CD.Name = "btnDesbloquear_82CD";
            this.btnDesbloquear_82CD.Size = new System.Drawing.Size(153, 49);
            this.btnDesbloquear_82CD.TabIndex = 18;
            this.btnDesbloquear_82CD.Text = "Desbloquear";
            this.btnDesbloquear_82CD.UseVisualStyleBackColor = false;
            // 
            // btnModificar_82CD
            // 
            this.btnModificar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnModificar_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnModificar_82CD.Location = new System.Drawing.Point(1120, 283);
            this.btnModificar_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar_82CD.Name = "btnModificar_82CD";
            this.btnModificar_82CD.Size = new System.Drawing.Size(153, 49);
            this.btnModificar_82CD.TabIndex = 19;
            this.btnModificar_82CD.Text = "Modificar";
            this.btnModificar_82CD.UseVisualStyleBackColor = false;
            this.btnModificar_82CD.Click += new System.EventHandler(this.btnModificar_82CD_Click);
            // 
            // btnActDesact_82CD
            // 
            this.btnActDesact_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnActDesact_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnActDesact_82CD.ForeColor = System.Drawing.Color.White;
            this.btnActDesact_82CD.Location = new System.Drawing.Point(1120, 363);
            this.btnActDesact_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnActDesact_82CD.Name = "btnActDesact_82CD";
            this.btnActDesact_82CD.Size = new System.Drawing.Size(153, 49);
            this.btnActDesact_82CD.TabIndex = 20;
            this.btnActDesact_82CD.Text = "Act / Desact.";
            this.btnActDesact_82CD.UseVisualStyleBackColor = false;
            // 
            // btnAplicar_82CD
            // 
            this.btnAplicar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnAplicar_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAplicar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnAplicar_82CD.Location = new System.Drawing.Point(1120, 443);
            this.btnAplicar_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicar_82CD.Name = "btnAplicar_82CD";
            this.btnAplicar_82CD.Size = new System.Drawing.Size(153, 49);
            this.btnAplicar_82CD.TabIndex = 21;
            this.btnAplicar_82CD.Text = "Aplicar";
            this.btnAplicar_82CD.UseVisualStyleBackColor = false;
            this.btnAplicar_82CD.Click += new System.EventHandler(this.btnAplicar_82CD_Click);
            // 
            // btnCancelar_82CD
            // 
            this.btnCancelar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnCancelar_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnCancelar_82CD.Location = new System.Drawing.Point(1120, 523);
            this.btnCancelar_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar_82CD.Name = "btnCancelar_82CD";
            this.btnCancelar_82CD.Size = new System.Drawing.Size(153, 49);
            this.btnCancelar_82CD.TabIndex = 22;
            this.btnCancelar_82CD.Text = "Cancelar";
            this.btnCancelar_82CD.UseVisualStyleBackColor = false;
            this.btnCancelar_82CD.Click += new System.EventHandler(this.btnCancelar_82CD_Click);
            // 
            // btnSalir_82CD
            // 
            this.btnSalir_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnSalir_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir_82CD.ForeColor = System.Drawing.Color.White;
            this.btnSalir_82CD.Location = new System.Drawing.Point(1120, 603);
            this.btnSalir_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir_82CD.Name = "btnSalir_82CD";
            this.btnSalir_82CD.Size = new System.Drawing.Size(153, 49);
            this.btnSalir_82CD.TabIndex = 23;
            this.btnSalir_82CD.Text = "Salir";
            this.btnSalir_82CD.UseVisualStyleBackColor = false;
            this.btnSalir_82CD.Click += new System.EventHandler(this.btnSalir_82CD_Click);
            // 
            // panFrmUsuario_82CD
            // 
            this.panFrmUsuario_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.panFrmUsuario_82CD.Location = new System.Drawing.Point(-1, 0);
            this.panFrmUsuario_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.panFrmUsuario_82CD.Name = "panFrmUsuario_82CD";
            this.panFrmUsuario_82CD.Size = new System.Drawing.Size(1313, 49);
            this.panFrmUsuario_82CD.TabIndex = 24;
            // 
            // lblBloqueado_82CD
            // 
            this.lblBloqueado_82CD.AutoSize = true;
            this.lblBloqueado_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblBloqueado_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblBloqueado_82CD.Location = new System.Drawing.Point(135, 647);
            this.lblBloqueado_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloqueado_82CD.Name = "lblBloqueado_82CD";
            this.lblBloqueado_82CD.Size = new System.Drawing.Size(93, 21);
            this.lblBloqueado_82CD.TabIndex = 26;
            this.lblBloqueado_82CD.Text = "Bloqueado";
            // 
            // lblActivo_82CD
            // 
            this.lblActivo_82CD.AutoSize = true;
            this.lblActivo_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblActivo_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblActivo_82CD.Location = new System.Drawing.Point(135, 692);
            this.lblActivo_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivo_82CD.Name = "lblActivo_82CD";
            this.lblActivo_82CD.Size = new System.Drawing.Size(59, 21);
            this.lblActivo_82CD.TabIndex = 28;
            this.lblActivo_82CD.Text = "Activo";
            // 
            // cmbRol_82CD
            // 
            this.cmbRol_82CD.FormattingEnabled = true;
            this.cmbRol_82CD.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbRol_82CD.Location = new System.Drawing.Point(265, 556);
            this.cmbRol_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRol_82CD.Name = "cmbRol_82CD";
            this.cmbRol_82CD.Size = new System.Drawing.Size(199, 24);
            this.cmbRol_82CD.TabIndex = 30;
            // 
            // rtbMensaje_82CD
            // 
            this.rtbMensaje_82CD.Location = new System.Drawing.Point(639, 386);
            this.rtbMensaje_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMensaje_82CD.Name = "rtbMensaje_82CD";
            this.rtbMensaje_82CD.Size = new System.Drawing.Size(427, 265);
            this.rtbMensaje_82CD.TabIndex = 31;
            this.rtbMensaje_82CD.Text = "";
            // 
            // lclCantUsuarios_82CD
            // 
            this.lclCantUsuarios_82CD.AutoSize = true;
            this.lclCantUsuarios_82CD.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lclCantUsuarios_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lclCantUsuarios_82CD.Location = new System.Drawing.Point(1020, 70);
            this.lclCantUsuarios_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lclCantUsuarios_82CD.Name = "lclCantUsuarios_82CD";
            this.lclCantUsuarios_82CD.Size = new System.Drawing.Size(0, 21);
            this.lclCantUsuarios_82CD.TabIndex = 32;
            // 
            // txtBloqueado_82CD
            // 
            this.txtBloqueado_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.txtBloqueado_82CD.Location = new System.Drawing.Point(265, 646);
            this.txtBloqueado_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloqueado_82CD.Name = "txtBloqueado_82CD";
            this.txtBloqueado_82CD.Size = new System.Drawing.Size(199, 22);
            this.txtBloqueado_82CD.TabIndex = 33;
            // 
            // txtActivo_82CD
            // 
            this.txtActivo_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.txtActivo_82CD.Location = new System.Drawing.Point(265, 692);
            this.txtActivo_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivo_82CD.Name = "txtActivo_82CD";
            this.txtActivo_82CD.Size = new System.Drawing.Size(199, 22);
            this.txtActivo_82CD.TabIndex = 34;
            // 
            // frmAdmin_82CD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.txtActivo_82CD);
            this.Controls.Add(this.txtBloqueado_82CD);
            this.Controls.Add(this.lclCantUsuarios_82CD);
            this.Controls.Add(this.rtbMensaje_82CD);
            this.Controls.Add(this.cmbRol_82CD);
            this.Controls.Add(this.lblActivo_82CD);
            this.Controls.Add(this.lblBloqueado_82CD);
            this.Controls.Add(this.panFrmUsuario_82CD);
            this.Controls.Add(this.btnSalir_82CD);
            this.Controls.Add(this.btnCancelar_82CD);
            this.Controls.Add(this.btnAplicar_82CD);
            this.Controls.Add(this.btnActDesact_82CD);
            this.Controls.Add(this.btnModificar_82CD);
            this.Controls.Add(this.btnDesbloquear_82CD);
            this.Controls.Add(this.btnCrear_82CD);
            this.Controls.Add(this.txtEmail_82CD);
            this.Controls.Add(this.txtLogin_82CD);
            this.Controls.Add(this.txtNombre_82CD);
            this.Controls.Add(this.txtApellidos_82CD);
            this.Controls.Add(this.txtDNI_82CD);
            this.Controls.Add(this.lblEmail_82CD);
            this.Controls.Add(this.lblLogin_82CD);
            this.Controls.Add(this.lblRol_82CD);
            this.Controls.Add(this.lblApellidos_82CD);
            this.Controls.Add(this.lblNombre_82CD);
            this.Controls.Add(this.lblDNI_82CD);
            this.Controls.Add(this.DGUsuarios_82CD);
            this.Controls.Add(this.lblNUsuarios_82CD);
            this.Controls.Add(this.radbtnTodos_82CD);
            this.Controls.Add(this.radbtnActivos_82CD);
            this.Controls.Add(this.lblTituloUsuarios_82CD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin_82CD";
            this.Text = "frmUsuarios_82CD";
            this.Load += new System.EventHandler(this.frmAdmin_82CD_Load);
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
        private System.Windows.Forms.Label lblApellidos_82CD;
        private System.Windows.Forms.Label lblRol_82CD;
        private System.Windows.Forms.Label lblLogin_82CD;
        private System.Windows.Forms.Label lblEmail_82CD;
        private System.Windows.Forms.TextBox txtDNI_82CD;
        private System.Windows.Forms.TextBox txtApellidos_82CD;
        private System.Windows.Forms.TextBox txtNombre_82CD;
        private System.Windows.Forms.TextBox txtLogin_82CD;
        private System.Windows.Forms.TextBox txtEmail_82CD;
        private System.Windows.Forms.Button btnCrear_82CD;
        private System.Windows.Forms.Button btnDesbloquear_82CD;
        private System.Windows.Forms.Button btnModificar_82CD;
        private System.Windows.Forms.Button btnActDesact_82CD;
        private System.Windows.Forms.Button btnAplicar_82CD;
        private System.Windows.Forms.Button btnCancelar_82CD;
        private System.Windows.Forms.Button btnSalir_82CD;
        private System.Windows.Forms.Panel panFrmUsuario_82CD;
        private System.Windows.Forms.Label lblBloqueado_82CD;
        private System.Windows.Forms.Label lblActivo_82CD;
        private System.Windows.Forms.ComboBox cmbRol_82CD;
        private System.Windows.Forms.RichTextBox rtbMensaje_82CD;
        private System.Windows.Forms.Label lclCantUsuarios_82CD;
        private System.Windows.Forms.TextBox txtBloqueado_82CD;
        private System.Windows.Forms.TextBox txtActivo_82CD;
    }
}