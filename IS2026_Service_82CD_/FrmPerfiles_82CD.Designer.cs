namespace IS2026_Service_82CD_
{
    partial class FrmPerfiles_82CD
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
            this.radbtnFamilias_82CD = new System.Windows.Forms.RadioButton();
            this.radbtnRoles_82CD = new System.Windows.Forms.RadioButton();
            this.treeFamRol_82CD = new System.Windows.Forms.TreeView();
            this.lstPeFam_82CD = new System.Windows.Forms.ListBox();
            this.lblRolFam_82CD = new System.Windows.Forms.Label();
            this.cmbRolFam_82CD = new System.Windows.Forms.ComboBox();
            this.btnCrear_82CD = new System.Windows.Forms.Button();
            this.btnEliminar_82CD = new System.Windows.Forms.Button();
            this.txtNombre_82CD = new System.Windows.Forms.TextBox();
            this.panFrmUsuario_82CD = new System.Windows.Forms.Panel();
            this.lblBitacora_82CD = new System.Windows.Forms.Label();
            this.btnAplicar_82CD = new System.Windows.Forms.Button();
            this.btnCancelar_82CD = new System.Windows.Forms.Button();
            this.lblNombre_82CD = new System.Windows.Forms.Label();
            this.lblSalir_82CD = new System.Windows.Forms.Label();
            this.rbtMensaje_82CD = new System.Windows.Forms.RichTextBox();
            this.btnModificar_82CD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radbtnFamilias_82CD
            // 
            this.radbtnFamilias_82CD.AutoSize = true;
            this.radbtnFamilias_82CD.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radbtnFamilias_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.radbtnFamilias_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.radbtnFamilias_82CD.Location = new System.Drawing.Point(1187, 71);
            this.radbtnFamilias_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnFamilias_82CD.Name = "radbtnFamilias_82CD";
            this.radbtnFamilias_82CD.Size = new System.Drawing.Size(71, 37);
            this.radbtnFamilias_82CD.TabIndex = 4;
            this.radbtnFamilias_82CD.TabStop = true;
            this.radbtnFamilias_82CD.Text = "Familias";
            this.radbtnFamilias_82CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radbtnFamilias_82CD.UseVisualStyleBackColor = true;
            this.radbtnFamilias_82CD.CheckedChanged += new System.EventHandler(this.radbtnFamilias_82CD_CheckedChanged);
            // 
            // radbtnRoles_82CD
            // 
            this.radbtnRoles_82CD.AutoSize = true;
            this.radbtnRoles_82CD.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radbtnRoles_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.radbtnRoles_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.radbtnRoles_82CD.Location = new System.Drawing.Point(1087, 71);
            this.radbtnRoles_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.radbtnRoles_82CD.Name = "radbtnRoles_82CD";
            this.radbtnRoles_82CD.Size = new System.Drawing.Size(53, 37);
            this.radbtnRoles_82CD.TabIndex = 3;
            this.radbtnRoles_82CD.TabStop = true;
            this.radbtnRoles_82CD.Text = "Roles";
            this.radbtnRoles_82CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radbtnRoles_82CD.UseVisualStyleBackColor = true;
            this.radbtnRoles_82CD.CheckedChanged += new System.EventHandler(this.radbtnRoles_82CD_CheckedChanged);
            // 
            // treeFamRol_82CD
            // 
            this.treeFamRol_82CD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeFamRol_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.treeFamRol_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.treeFamRol_82CD.Location = new System.Drawing.Point(33, 123);
            this.treeFamRol_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.treeFamRol_82CD.Name = "treeFamRol_82CD";
            this.treeFamRol_82CD.Size = new System.Drawing.Size(599, 308);
            this.treeFamRol_82CD.TabIndex = 5;
            this.treeFamRol_82CD.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFamRol_82CD_AfterSelect);
            // 
            // lstPeFam_82CD
            // 
            this.lstPeFam_82CD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstPeFam_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lstPeFam_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lstPeFam_82CD.FormattingEnabled = true;
            this.lstPeFam_82CD.ItemHeight = 16;
            this.lstPeFam_82CD.Location = new System.Drawing.Point(669, 123);
            this.lstPeFam_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.lstPeFam_82CD.Name = "lstPeFam_82CD";
            this.lstPeFam_82CD.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPeFam_82CD.Size = new System.Drawing.Size(599, 308);
            this.lstPeFam_82CD.TabIndex = 6;
            this.lstPeFam_82CD.SelectedIndexChanged += new System.EventHandler(this.lstPeFam_82CD_SelectedIndexChanged);
            // 
            // lblRolFam_82CD
            // 
            this.lblRolFam_82CD.AutoSize = true;
            this.lblRolFam_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRolFam_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblRolFam_82CD.Location = new System.Drawing.Point(349, 523);
            this.lblRolFam_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolFam_82CD.Name = "lblRolFam_82CD";
            this.lblRolFam_82CD.Size = new System.Drawing.Size(0, 18);
            this.lblRolFam_82CD.TabIndex = 8;
            // 
            // cmbRolFam_82CD
            // 
            this.cmbRolFam_82CD.FormattingEnabled = true;
            this.cmbRolFam_82CD.Location = new System.Drawing.Point(345, 548);
            this.cmbRolFam_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRolFam_82CD.Name = "cmbRolFam_82CD";
            this.cmbRolFam_82CD.Size = new System.Drawing.Size(179, 24);
            this.cmbRolFam_82CD.TabIndex = 9;
            this.cmbRolFam_82CD.SelectedIndexChanged += new System.EventHandler(this.cmbRolFam_82CD_SelectedIndexChanged);
            // 
            // btnCrear_82CD
            // 
            this.btnCrear_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnCrear_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCrear_82CD.ForeColor = System.Drawing.Color.White;
            this.btnCrear_82CD.Location = new System.Drawing.Point(146, 451);
            this.btnCrear_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear_82CD.Name = "btnCrear_82CD";
            this.btnCrear_82CD.Size = new System.Drawing.Size(167, 52);
            this.btnCrear_82CD.TabIndex = 92;
            this.btnCrear_82CD.Text = "Crear";
            this.btnCrear_82CD.UseVisualStyleBackColor = false;
            this.btnCrear_82CD.Click += new System.EventHandler(this.btnCrear_82CD_Click);
            // 
            // btnEliminar_82CD
            // 
            this.btnEliminar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnEliminar_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnEliminar_82CD.Location = new System.Drawing.Point(145, 525);
            this.btnEliminar_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar_82CD.Name = "btnEliminar_82CD";
            this.btnEliminar_82CD.Size = new System.Drawing.Size(167, 52);
            this.btnEliminar_82CD.TabIndex = 94;
            this.btnEliminar_82CD.Text = "Eliminar";
            this.btnEliminar_82CD.UseVisualStyleBackColor = false;
            this.btnEliminar_82CD.Click += new System.EventHandler(this.btnEliminar_82CD_Click);
            // 
            // txtNombre_82CD
            // 
            this.txtNombre_82CD.Location = new System.Drawing.Point(346, 476);
            this.txtNombre_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre_82CD.Name = "txtNombre_82CD";
            this.txtNombre_82CD.Size = new System.Drawing.Size(179, 22);
            this.txtNombre_82CD.TabIndex = 95;
            // 
            // panFrmUsuario_82CD
            // 
            this.panFrmUsuario_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.panFrmUsuario_82CD.Location = new System.Drawing.Point(0, 0);
            this.panFrmUsuario_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.panFrmUsuario_82CD.Name = "panFrmUsuario_82CD";
            this.panFrmUsuario_82CD.Size = new System.Drawing.Size(1313, 53);
            this.panFrmUsuario_82CD.TabIndex = 96;
            // 
            // lblBitacora_82CD
            // 
            this.lblBitacora_82CD.AutoSize = true;
            this.lblBitacora_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblBitacora_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblBitacora_82CD.Location = new System.Drawing.Point(27, 71);
            this.lblBitacora_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitacora_82CD.Name = "lblBitacora_82CD";
            this.lblBitacora_82CD.Size = new System.Drawing.Size(237, 29);
            this.lblBitacora_82CD.TabIndex = 97;
            this.lblBitacora_82CD.Text = "Gestión de Perfiles";
            // 
            // btnAplicar_82CD
            // 
            this.btnAplicar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnAplicar_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAplicar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnAplicar_82CD.Location = new System.Drawing.Point(455, 671);
            this.btnAplicar_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicar_82CD.Name = "btnAplicar_82CD";
            this.btnAplicar_82CD.Size = new System.Drawing.Size(177, 42);
            this.btnAplicar_82CD.TabIndex = 98;
            this.btnAplicar_82CD.Text = "Aplicar";
            this.btnAplicar_82CD.UseVisualStyleBackColor = false;
            this.btnAplicar_82CD.Click += new System.EventHandler(this.btnAplicar_82CD_Click);
            // 
            // btnCancelar_82CD
            // 
            this.btnCancelar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnCancelar_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnCancelar_82CD.Location = new System.Drawing.Point(669, 671);
            this.btnCancelar_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar_82CD.Name = "btnCancelar_82CD";
            this.btnCancelar_82CD.Size = new System.Drawing.Size(177, 42);
            this.btnCancelar_82CD.TabIndex = 99;
            this.btnCancelar_82CD.Text = "Cancelar";
            this.btnCancelar_82CD.UseVisualStyleBackColor = false;
            this.btnCancelar_82CD.Click += new System.EventHandler(this.btnCancelar_82CD_Click);
            // 
            // lblNombre_82CD
            // 
            this.lblNombre_82CD.AutoSize = true;
            this.lblNombre_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblNombre_82CD.Location = new System.Drawing.Point(342, 449);
            this.lblNombre_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre_82CD.Name = "lblNombre_82CD";
            this.lblNombre_82CD.Size = new System.Drawing.Size(68, 18);
            this.lblNombre_82CD.TabIndex = 100;
            this.lblNombre_82CD.Text = "Nombre";
            // 
            // lblSalir_82CD
            // 
            this.lblSalir_82CD.AutoSize = true;
            this.lblSalir_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblSalir_82CD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.lblSalir_82CD.Location = new System.Drawing.Point(1229, 712);
            this.lblSalir_82CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalir_82CD.Name = "lblSalir_82CD";
            this.lblSalir_82CD.Size = new System.Drawing.Size(60, 25);
            this.lblSalir_82CD.TabIndex = 101;
            this.lblSalir_82CD.Text = "Salir";
            this.lblSalir_82CD.Click += new System.EventHandler(this.lblSalir_82CD_Click);
            // 
            // rbtMensaje_82CD
            // 
            this.rbtMensaje_82CD.Location = new System.Drawing.Point(758, 448);
            this.rbtMensaje_82CD.Name = "rbtMensaje_82CD";
            this.rbtMensaje_82CD.Size = new System.Drawing.Size(446, 157);
            this.rbtMensaje_82CD.TabIndex = 102;
            this.rbtMensaje_82CD.Text = "";
            // 
            // btnModificar_82CD
            // 
            this.btnModificar_82CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(120)))));
            this.btnModificar_82CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificar_82CD.ForeColor = System.Drawing.Color.White;
            this.btnModificar_82CD.Location = new System.Drawing.Point(145, 594);
            this.btnModificar_82CD.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar_82CD.Name = "btnModificar_82CD";
            this.btnModificar_82CD.Size = new System.Drawing.Size(166, 52);
            this.btnModificar_82CD.TabIndex = 103;
            this.btnModificar_82CD.Text = "Modificar";
            this.btnModificar_82CD.UseVisualStyleBackColor = false;
            this.btnModificar_82CD.Click += new System.EventHandler(this.btnModificar_82CD_Click);
            // 
            // FrmPerfiles_82CD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 746);
            this.Controls.Add(this.btnModificar_82CD);
            this.Controls.Add(this.rbtMensaje_82CD);
            this.Controls.Add(this.lblSalir_82CD);
            this.Controls.Add(this.lblNombre_82CD);
            this.Controls.Add(this.btnCancelar_82CD);
            this.Controls.Add(this.btnAplicar_82CD);
            this.Controls.Add(this.lblBitacora_82CD);
            this.Controls.Add(this.panFrmUsuario_82CD);
            this.Controls.Add(this.txtNombre_82CD);
            this.Controls.Add(this.btnEliminar_82CD);
            this.Controls.Add(this.btnCrear_82CD);
            this.Controls.Add(this.cmbRolFam_82CD);
            this.Controls.Add(this.lblRolFam_82CD);
            this.Controls.Add(this.lstPeFam_82CD);
            this.Controls.Add(this.treeFamRol_82CD);
            this.Controls.Add(this.radbtnFamilias_82CD);
            this.Controls.Add(this.radbtnRoles_82CD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPerfiles_82CD";
            this.Text = "FrmPerfiles_82CD";
            this.Load += new System.EventHandler(this.FrmPerfiles_82CD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radbtnFamilias_82CD;
        private System.Windows.Forms.RadioButton radbtnRoles_82CD;
        private System.Windows.Forms.TreeView treeFamRol_82CD;
        private System.Windows.Forms.ListBox lstPeFam_82CD;
        private System.Windows.Forms.Label lblRolFam_82CD;
        private System.Windows.Forms.ComboBox cmbRolFam_82CD;
        private System.Windows.Forms.Button btnCrear_82CD;
        private System.Windows.Forms.Button btnEliminar_82CD;
        private System.Windows.Forms.TextBox txtNombre_82CD;
        private System.Windows.Forms.Panel panFrmUsuario_82CD;
        private System.Windows.Forms.Label lblBitacora_82CD;
        private System.Windows.Forms.Button btnAplicar_82CD;
        private System.Windows.Forms.Button btnCancelar_82CD;
        private System.Windows.Forms.Label lblNombre_82CD;
        private System.Windows.Forms.Label lblSalir_82CD;
        private System.Windows.Forms.RichTextBox rbtMensaje_82CD;
        private System.Windows.Forms.Button btnModificar_82CD;
    }
}