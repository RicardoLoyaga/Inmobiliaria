namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmParroquia
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
            this.lblprovincia = new MaterialSkin.Controls.MaterialLabel();
            this.lblCantón = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreBarrio = new MaterialSkin.Controls.MaterialLabel();
            this.dgvParroquia = new System.Windows.Forms.DataGridView();
            this.lblEstadoParroquia = new MaterialSkin.Controls.MaterialLabel();
            this.cboCantón = new System.Windows.Forms.ComboBox();
            this.cbxEstadoParroquia = new System.Windows.Forms.CheckBox();
            this.btnGuardarParroquia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelarParroquia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdParroquia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProvincia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreBarrio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParroquia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprovincia
            // 
            this.lblprovincia.AutoSize = true;
            this.lblprovincia.Depth = 0;
            this.lblprovincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblprovincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblprovincia.Location = new System.Drawing.Point(281, 77);
            this.lblprovincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblprovincia.Name = "lblprovincia";
            this.lblprovincia.Size = new System.Drawing.Size(79, 19);
            this.lblprovincia.TabIndex = 1;
            this.lblprovincia.Text = "Provincia: ";
            // 
            // lblCantón
            // 
            this.lblCantón.AutoSize = true;
            this.lblCantón.Depth = 0;
            this.lblCantón.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCantón.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantón.Location = new System.Drawing.Point(523, 77);
            this.lblCantón.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantón.Name = "lblCantón";
            this.lblCantón.Size = new System.Drawing.Size(65, 19);
            this.lblCantón.TabIndex = 5;
            this.lblCantón.Text = "Cantón: ";
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.Depth = 0;
            this.lblNombreBarrio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreBarrio.Location = new System.Drawing.Point(26, 107);
            this.lblNombreBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(115, 19);
            this.lblNombreBarrio.TabIndex = 7;
            this.lblNombreBarrio.Text = "Nombre Barrio: ";
            // 
            // dgvParroquia
            // 
            this.dgvParroquia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParroquia.Location = new System.Drawing.Point(12, 134);
            this.dgvParroquia.Name = "dgvParroquia";
            this.dgvParroquia.Size = new System.Drawing.Size(776, 162);
            this.dgvParroquia.TabIndex = 11;
            // 
            // lblEstadoParroquia
            // 
            this.lblEstadoParroquia.AutoSize = true;
            this.lblEstadoParroquia.Depth = 0;
            this.lblEstadoParroquia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoParroquia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoParroquia.Location = new System.Drawing.Point(322, 107);
            this.lblEstadoParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoParroquia.Name = "lblEstadoParroquia";
            this.lblEstadoParroquia.Size = new System.Drawing.Size(64, 19);
            this.lblEstadoParroquia.TabIndex = 12;
            this.lblEstadoParroquia.Text = "Estado: ";
            // 
            // cboCantón
            // 
            this.cboCantón.FormattingEnabled = true;
            this.cboCantón.Location = new System.Drawing.Point(607, 73);
            this.cboCantón.Name = "cboCantón";
            this.cboCantón.Size = new System.Drawing.Size(135, 21);
            this.cboCantón.TabIndex = 25;
            // 
            // cbxEstadoParroquia
            // 
            this.cbxEstadoParroquia.AutoSize = true;
            this.cbxEstadoParroquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoParroquia.Location = new System.Drawing.Point(392, 107);
            this.cbxEstadoParroquia.Name = "cbxEstadoParroquia";
            this.cbxEstadoParroquia.Size = new System.Drawing.Size(65, 21);
            this.cbxEstadoParroquia.TabIndex = 27;
            this.cbxEstadoParroquia.Text = "Activo";
            this.cbxEstadoParroquia.UseVisualStyleBackColor = true;
            // 
            // btnGuardarParroquia
            // 
            this.btnGuardarParroquia.Depth = 0;
            this.btnGuardarParroquia.Location = new System.Drawing.Point(326, 302);
            this.btnGuardarParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarParroquia.Name = "btnGuardarParroquia";
            this.btnGuardarParroquia.Primary = true;
            this.btnGuardarParroquia.Size = new System.Drawing.Size(82, 36);
            this.btnGuardarParroquia.TabIndex = 28;
            this.btnGuardarParroquia.Text = "Guardar";
            this.btnGuardarParroquia.UseVisualStyleBackColor = true;
            // 
            // btnCancelarParroquia
            // 
            this.btnCancelarParroquia.Depth = 0;
            this.btnCancelarParroquia.Location = new System.Drawing.Point(445, 302);
            this.btnCancelarParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarParroquia.Name = "btnCancelarParroquia";
            this.btnCancelarParroquia.Primary = true;
            this.btnCancelarParroquia.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarParroquia.TabIndex = 29;
            this.btnCancelarParroquia.Text = "Cancelar";
            this.btnCancelarParroquia.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Id Parroquia: ";
            // 
            // txtIdParroquia
            // 
            this.txtIdParroquia.Depth = 0;
            this.txtIdParroquia.Hint = "";
            this.txtIdParroquia.Location = new System.Drawing.Point(130, 73);
            this.txtIdParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdParroquia.Name = "txtIdParroquia";
            this.txtIdParroquia.PasswordChar = '\0';
            this.txtIdParroquia.SelectedText = "";
            this.txtIdParroquia.SelectionLength = 0;
            this.txtIdParroquia.SelectionStart = 0;
            this.txtIdParroquia.Size = new System.Drawing.Size(135, 23);
            this.txtIdParroquia.TabIndex = 31;
            this.txtIdParroquia.UseSystemPasswordChar = false;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Depth = 0;
            this.txtProvincia.Hint = "";
            this.txtProvincia.Location = new System.Drawing.Point(366, 73);
            this.txtProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.PasswordChar = '\0';
            this.txtProvincia.SelectedText = "";
            this.txtProvincia.SelectionLength = 0;
            this.txtProvincia.SelectionStart = 0;
            this.txtProvincia.Size = new System.Drawing.Size(135, 23);
            this.txtProvincia.TabIndex = 32;
            this.txtProvincia.UseSystemPasswordChar = false;
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Depth = 0;
            this.txtNombreBarrio.Hint = "";
            this.txtNombreBarrio.Location = new System.Drawing.Point(147, 103);
            this.txtNombreBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.PasswordChar = '\0';
            this.txtNombreBarrio.SelectedText = "";
            this.txtNombreBarrio.SelectionLength = 0;
            this.txtNombreBarrio.SelectionStart = 0;
            this.txtNombreBarrio.Size = new System.Drawing.Size(135, 23);
            this.txtNombreBarrio.TabIndex = 33;
            this.txtNombreBarrio.UseSystemPasswordChar = false;
            // 
            // FrmParroquia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.txtNombreBarrio);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtIdParroquia);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCancelarParroquia);
            this.Controls.Add(this.btnGuardarParroquia);
            this.Controls.Add(this.cbxEstadoParroquia);
            this.Controls.Add(this.cboCantón);
            this.Controls.Add(this.lblEstadoParroquia);
            this.Controls.Add(this.dgvParroquia);
            this.Controls.Add(this.lblNombreBarrio);
            this.Controls.Add(this.lblCantón);
            this.Controls.Add(this.lblprovincia);
            this.Name = "FrmParroquia";
            this.Text = "Información Parroquia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParroquia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblprovincia;
        private MaterialSkin.Controls.MaterialLabel lblCantón;
        private MaterialSkin.Controls.MaterialLabel lblNombreBarrio;
        private System.Windows.Forms.DataGridView dgvParroquia;
        private MaterialSkin.Controls.MaterialLabel lblEstadoParroquia;
        private System.Windows.Forms.ComboBox cboCantón;
        private System.Windows.Forms.CheckBox cbxEstadoParroquia;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarParroquia;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelarParroquia;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdParroquia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProvincia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreBarrio;
    }
}