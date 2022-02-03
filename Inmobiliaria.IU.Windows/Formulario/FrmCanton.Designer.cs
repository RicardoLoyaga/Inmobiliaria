namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmCanton
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
            this.lblProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.lblParroquia = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoCantón = new MaterialSkin.Controls.MaterialLabel();
            this.dgvCantón = new System.Windows.Forms.DataGridView();
            this.lblNombreBarrio = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardarCantón = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelarCantón = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbxEstadoCantón = new System.Windows.Forms.CheckBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCantón = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtParroquia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreBarrio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantón)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvincia
            // 
            this.lblProvincia.Depth = 0;
            this.lblProvincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProvincia.Location = new System.Drawing.Point(265, 75);
            this.lblProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(95, 19);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblParroquia
            // 
            this.lblParroquia.Depth = 0;
            this.lblParroquia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblParroquia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParroquia.Location = new System.Drawing.Point(522, 78);
            this.lblParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblParroquia.Name = "lblParroquia";
            this.lblParroquia.Size = new System.Drawing.Size(95, 19);
            this.lblParroquia.TabIndex = 2;
            this.lblParroquia.Text = "Parroquia:";
            // 
            // lblEstadoCantón
            // 
            this.lblEstadoCantón.Depth = 0;
            this.lblEstadoCantón.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoCantón.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoCantón.Location = new System.Drawing.Point(270, 115);
            this.lblEstadoCantón.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoCantón.Name = "lblEstadoCantón";
            this.lblEstadoCantón.Size = new System.Drawing.Size(64, 19);
            this.lblEstadoCantón.TabIndex = 4;
            this.lblEstadoCantón.Text = "Estado:";
            // 
            // dgvCantón
            // 
            this.dgvCantón.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantón.Location = new System.Drawing.Point(12, 143);
            this.dgvCantón.Name = "dgvCantón";
            this.dgvCantón.Size = new System.Drawing.Size(776, 153);
            this.dgvCantón.TabIndex = 8;
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.Depth = 0;
            this.lblNombreBarrio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreBarrio.Location = new System.Drawing.Point(12, 115);
            this.lblNombreBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(111, 19);
            this.lblNombreBarrio.TabIndex = 9;
            this.lblNombreBarrio.Text = "Nombre Barrio:";
            // 
            // btnGuardarCantón
            // 
            this.btnGuardarCantón.Depth = 0;
            this.btnGuardarCantón.Location = new System.Drawing.Point(315, 302);
            this.btnGuardarCantón.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCantón.Name = "btnGuardarCantón";
            this.btnGuardarCantón.Primary = true;
            this.btnGuardarCantón.Size = new System.Drawing.Size(82, 36);
            this.btnGuardarCantón.TabIndex = 20;
            this.btnGuardarCantón.Text = "Guardar";
            this.btnGuardarCantón.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCantón
            // 
            this.btnCancelarCantón.Depth = 0;
            this.btnCancelarCantón.Location = new System.Drawing.Point(434, 302);
            this.btnCancelarCantón.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarCantón.Name = "btnCancelarCantón";
            this.btnCancelarCantón.Primary = true;
            this.btnCancelarCantón.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarCantón.TabIndex = 21;
            this.btnCancelarCantón.Text = "Cancelar";
            this.btnCancelarCantón.UseVisualStyleBackColor = true;
            // 
            // cbxEstadoCantón
            // 
            this.cbxEstadoCantón.AutoSize = true;
            this.cbxEstadoCantón.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoCantón.Location = new System.Drawing.Point(352, 116);
            this.cbxEstadoCantón.Name = "cbxEstadoCantón";
            this.cbxEstadoCantón.Size = new System.Drawing.Size(65, 21);
            this.cbxEstadoCantón.TabIndex = 22;
            this.cbxEstadoCantón.Text = "Activo";
            this.cbxEstadoCantón.UseVisualStyleBackColor = true;
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(366, 76);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(135, 21);
            this.cboProvincia.TabIndex = 23;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Id Cantón:";
            // 
            // txtIdCantón
            // 
            this.txtIdCantón.Depth = 0;
            this.txtIdCantón.Hint = "";
            this.txtIdCantón.Location = new System.Drawing.Point(113, 75);
            this.txtIdCantón.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCantón.Name = "txtIdCantón";
            this.txtIdCantón.PasswordChar = '\0';
            this.txtIdCantón.SelectedText = "";
            this.txtIdCantón.SelectionLength = 0;
            this.txtIdCantón.SelectionStart = 0;
            this.txtIdCantón.Size = new System.Drawing.Size(135, 23);
            this.txtIdCantón.TabIndex = 27;
            this.txtIdCantón.UseSystemPasswordChar = false;
            // 
            // txtParroquia
            // 
            this.txtParroquia.Depth = 0;
            this.txtParroquia.Hint = "";
            this.txtParroquia.Location = new System.Drawing.Point(635, 76);
            this.txtParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtParroquia.Name = "txtParroquia";
            this.txtParroquia.PasswordChar = '\0';
            this.txtParroquia.SelectedText = "";
            this.txtParroquia.SelectionLength = 0;
            this.txtParroquia.SelectionStart = 0;
            this.txtParroquia.Size = new System.Drawing.Size(135, 23);
            this.txtParroquia.TabIndex = 28;
            this.txtParroquia.UseSystemPasswordChar = false;
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Depth = 0;
            this.txtNombreBarrio.Hint = "";
            this.txtNombreBarrio.Location = new System.Drawing.Point(129, 111);
            this.txtNombreBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.PasswordChar = '\0';
            this.txtNombreBarrio.SelectedText = "";
            this.txtNombreBarrio.SelectionLength = 0;
            this.txtNombreBarrio.SelectionStart = 0;
            this.txtNombreBarrio.Size = new System.Drawing.Size(135, 23);
            this.txtNombreBarrio.TabIndex = 29;
            this.txtNombreBarrio.UseSystemPasswordChar = false;
            // 
            // FrmCanton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.txtNombreBarrio);
            this.Controls.Add(this.txtParroquia);
            this.Controls.Add(this.txtIdCantón);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.cbxEstadoCantón);
            this.Controls.Add(this.btnCancelarCantón);
            this.Controls.Add(this.btnGuardarCantón);
            this.Controls.Add(this.lblNombreBarrio);
            this.Controls.Add(this.dgvCantón);
            this.Controls.Add(this.lblEstadoCantón);
            this.Controls.Add(this.lblParroquia);
            this.Controls.Add(this.lblProvincia);
            this.Name = "FrmCanton";
            this.Text = "Información Cantón";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantón)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblProvincia;
        private MaterialSkin.Controls.MaterialLabel lblParroquia;
        private MaterialSkin.Controls.MaterialLabel lblEstadoCantón;
        private System.Windows.Forms.DataGridView dgvCantón;
        private MaterialSkin.Controls.MaterialLabel lblNombreBarrio;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarCantón;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelarCantón;
        private System.Windows.Forms.CheckBox cbxEstadoCantón;
        private System.Windows.Forms.ComboBox cboProvincia;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCantón;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtParroquia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreBarrio;
    }
}