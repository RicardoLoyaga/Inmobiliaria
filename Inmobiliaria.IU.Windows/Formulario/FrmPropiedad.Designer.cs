namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmPropiedad
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
            this.lblIdPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblIdCaracteristica = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.lblPropietario = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.dgvPropiedad = new System.Windows.Forms.DataGridView();
            this.btnGuardarPropiedad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboTipoPropiedad = new System.Windows.Forms.ComboBox();
            this.cboCaracteristica = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.lblCanton = new MaterialSkin.Controls.MaterialLabel();
            this.lblParroquia = new MaterialSkin.Controls.MaterialLabel();
            this.lblBarrio = new MaterialSkin.Controls.MaterialLabel();
            this.cboCanton = new System.Windows.Forms.ComboBox();
            this.cboParroquia = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.cboPropietario = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbxEstadoPropiedad = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtIdPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.cboUsuarioPropiedad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPropiedad
            // 
            this.lblIdPropiedad.AutoSize = true;
            this.lblIdPropiedad.Depth = 0;
            this.lblIdPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdPropiedad.Location = new System.Drawing.Point(47, 75);
            this.lblIdPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdPropiedad.Name = "lblIdPropiedad";
            this.lblIdPropiedad.Size = new System.Drawing.Size(96, 19);
            this.lblIdPropiedad.TabIndex = 0;
            this.lblIdPropiedad.Text = "Id Propiedad:";
            // 
            // lblIdCaracteristica
            // 
            this.lblIdCaracteristica.AutoSize = true;
            this.lblIdCaracteristica.Depth = 0;
            this.lblIdCaracteristica.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdCaracteristica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdCaracteristica.Location = new System.Drawing.Point(338, 103);
            this.lblIdCaracteristica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCaracteristica.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdCaracteristica.Name = "lblIdCaracteristica";
            this.lblIdCaracteristica.Size = new System.Drawing.Size(107, 19);
            this.lblIdCaracteristica.TabIndex = 1;
            this.lblIdCaracteristica.Text = "Característica:";
            // 
            // lblTipoPropiedad
            // 
            this.lblTipoPropiedad.AutoSize = true;
            this.lblTipoPropiedad.Depth = 0;
            this.lblTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoPropiedad.Location = new System.Drawing.Point(29, 101);
            this.lblTipoPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoPropiedad.Name = "lblTipoPropiedad";
            this.lblTipoPropiedad.Size = new System.Drawing.Size(114, 19);
            this.lblTipoPropiedad.TabIndex = 2;
            this.lblTipoPropiedad.Text = "Tipo Propiedad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Depth = 0;
            this.lblProvincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProvincia.Location = new System.Drawing.Point(66, 127);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(75, 19);
            this.lblProvincia.TabIndex = 3;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Depth = 0;
            this.lblPropietario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPropietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPropietario.Location = new System.Drawing.Point(55, 181);
            this.lblPropietario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropietario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(87, 19);
            this.lblPropietario.TabIndex = 4;
            this.lblPropietario.Text = "Propietario:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Depth = 0;
            this.lblPrecio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecio.Location = new System.Drawing.Point(386, 183);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 19);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblEstadoPropiedad
            // 
            this.lblEstadoPropiedad.AutoSize = true;
            this.lblEstadoPropiedad.Depth = 0;
            this.lblEstadoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoPropiedad.Location = new System.Drawing.Point(81, 209);
            this.lblEstadoPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoPropiedad.Name = "lblEstadoPropiedad";
            this.lblEstadoPropiedad.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoPropiedad.TabIndex = 6;
            this.lblEstadoPropiedad.Text = "Estado:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(379, 77);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario:";
            // 
            // dgvPropiedad
            // 
            this.dgvPropiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedad.Location = new System.Drawing.Point(51, 238);
            this.dgvPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPropiedad.Name = "dgvPropiedad";
            this.dgvPropiedad.RowHeadersWidth = 62;
            this.dgvPropiedad.RowTemplate.Height = 28;
            this.dgvPropiedad.Size = new System.Drawing.Size(575, 77);
            this.dgvPropiedad.TabIndex = 12;
            // 
            // btnGuardarPropiedad
            // 
            this.btnGuardarPropiedad.Depth = 0;
            this.btnGuardarPropiedad.Location = new System.Drawing.Point(238, 324);
            this.btnGuardarPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            this.btnGuardarPropiedad.Primary = true;
            this.btnGuardarPropiedad.Size = new System.Drawing.Size(91, 34);
            this.btnGuardarPropiedad.TabIndex = 9;
            this.btnGuardarPropiedad.Text = "Guardar";
            this.btnGuardarPropiedad.UseVisualStyleBackColor = true;
            this.btnGuardarPropiedad.Click += new System.EventHandler(this.btnGuardarPropiedad_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(341, 324);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(91, 34);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTipoPropiedad
            // 
            this.cboTipoPropiedad.FormattingEnabled = true;
            this.cboTipoPropiedad.Location = new System.Drawing.Point(142, 101);
            this.cboTipoPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoPropiedad.Name = "cboTipoPropiedad";
            this.cboTipoPropiedad.Size = new System.Drawing.Size(181, 21);
            this.cboTipoPropiedad.TabIndex = 3;
            // 
            // cboCaracteristica
            // 
            this.cboCaracteristica.FormattingEnabled = true;
            this.cboCaracteristica.Location = new System.Drawing.Point(449, 103);
            this.cboCaracteristica.Margin = new System.Windows.Forms.Padding(2);
            this.cboCaracteristica.Name = "cboCaracteristica";
            this.cboCaracteristica.Size = new System.Drawing.Size(178, 21);
            this.cboCaracteristica.TabIndex = 4;
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(142, 127);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(215, 21);
            this.cboProvincia.TabIndex = 5;
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Depth = 0;
            this.lblCanton.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCanton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCanton.Location = new System.Drawing.Point(381, 127);
            this.lblCanton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanton.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(61, 19);
            this.lblCanton.TabIndex = 16;
            this.lblCanton.Text = "Cantón:";
            // 
            // lblParroquia
            // 
            this.lblParroquia.AutoSize = true;
            this.lblParroquia.Depth = 0;
            this.lblParroquia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblParroquia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParroquia.Location = new System.Drawing.Point(63, 153);
            this.lblParroquia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblParroquia.Name = "lblParroquia";
            this.lblParroquia.Size = new System.Drawing.Size(78, 19);
            this.lblParroquia.TabIndex = 17;
            this.lblParroquia.Text = "Parroquia:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Depth = 0;
            this.lblBarrio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBarrio.Location = new System.Drawing.Point(389, 155);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(53, 19);
            this.lblBarrio.TabIndex = 18;
            this.lblBarrio.Text = "Barrio:";
            // 
            // cboCanton
            // 
            this.cboCanton.FormattingEnabled = true;
            this.cboCanton.Location = new System.Drawing.Point(449, 128);
            this.cboCanton.Margin = new System.Windows.Forms.Padding(2);
            this.cboCanton.Name = "cboCanton";
            this.cboCanton.Size = new System.Drawing.Size(178, 21);
            this.cboCanton.TabIndex = 6;
            // 
            // cboParroquia
            // 
            this.cboParroquia.FormattingEnabled = true;
            this.cboParroquia.Location = new System.Drawing.Point(142, 153);
            this.cboParroquia.Margin = new System.Windows.Forms.Padding(2);
            this.cboParroquia.Name = "cboParroquia";
            this.cboParroquia.Size = new System.Drawing.Size(215, 21);
            this.cboParroquia.TabIndex = 7;
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(449, 155);
            this.cboBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(178, 21);
            this.cboBarrio.TabIndex = 8;
            // 
            // cboPropietario
            // 
            this.cboPropietario.FormattingEnabled = true;
            this.cboPropietario.Location = new System.Drawing.Point(142, 181);
            this.cboPropietario.Margin = new System.Windows.Forms.Padding(2);
            this.cboPropietario.Name = "cboPropietario";
            this.cboPropietario.Size = new System.Drawing.Size(215, 21);
            this.cboPropietario.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "";
            this.txtPrecio.Location = new System.Drawing.Point(445, 183);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(131, 23);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // cbxEstadoPropiedad
            // 
            this.cbxEstadoPropiedad.AutoSize = true;
            this.cbxEstadoPropiedad.Depth = 0;
            this.cbxEstadoPropiedad.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxEstadoPropiedad.Location = new System.Drawing.Point(146, 205);
            this.cbxEstadoPropiedad.Margin = new System.Windows.Forms.Padding(0);
            this.cbxEstadoPropiedad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxEstadoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxEstadoPropiedad.Name = "cbxEstadoPropiedad";
            this.cbxEstadoPropiedad.Ripple = true;
            this.cbxEstadoPropiedad.Size = new System.Drawing.Size(69, 30);
            this.cbxEstadoPropiedad.TabIndex = 19;
            this.cbxEstadoPropiedad.Text = "Activo";
            this.cbxEstadoPropiedad.UseVisualStyleBackColor = true;
            // 
            // txtIdPropiedad
            // 
            this.txtIdPropiedad.AutoSize = true;
            this.txtIdPropiedad.Depth = 0;
            this.txtIdPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtIdPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdPropiedad.Location = new System.Drawing.Point(148, 77);
            this.txtIdPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdPropiedad.Name = "txtIdPropiedad";
            this.txtIdPropiedad.Size = new System.Drawing.Size(0, 19);
            this.txtIdPropiedad.TabIndex = 20;
            // 
            // cboUsuarioPropiedad
            // 
            this.cboUsuarioPropiedad.FormattingEnabled = true;
            this.cboUsuarioPropiedad.Location = new System.Drawing.Point(449, 76);
            this.cboUsuarioPropiedad.Name = "cboUsuarioPropiedad";
            this.cboUsuarioPropiedad.Size = new System.Drawing.Size(177, 21);
            this.cboUsuarioPropiedad.TabIndex = 21;
            // 
            // FrmPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 367);
            this.Controls.Add(this.cboUsuarioPropiedad);
            this.Controls.Add(this.txtIdPropiedad);
            this.Controls.Add(this.cbxEstadoPropiedad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboPropietario);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.cboParroquia);
            this.Controls.Add(this.cboCanton);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblParroquia);
            this.Controls.Add(this.lblCanton);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.cboCaracteristica);
            this.Controls.Add(this.cboTipoPropiedad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarPropiedad);
            this.Controls.Add(this.dgvPropiedad);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblEstadoPropiedad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblTipoPropiedad);
            this.Controls.Add(this.lblIdCaracteristica);
            this.Controls.Add(this.lblIdPropiedad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPropiedad";
            this.Text = "Propiedad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblIdPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblIdCaracteristica;
        private MaterialSkin.Controls.MaterialLabel lblTipoPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblProvincia;
        private MaterialSkin.Controls.MaterialLabel lblPropietario;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialLabel lblEstadoPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private System.Windows.Forms.DataGridView dgvPropiedad;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarPropiedad;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.ComboBox cboTipoPropiedad;
        private System.Windows.Forms.ComboBox cboCaracteristica;
        private System.Windows.Forms.ComboBox cboProvincia;
        private MaterialSkin.Controls.MaterialLabel lblCanton;
        private MaterialSkin.Controls.MaterialLabel lblParroquia;
        private MaterialSkin.Controls.MaterialLabel lblBarrio;
        private System.Windows.Forms.ComboBox cboCanton;
        private System.Windows.Forms.ComboBox cboParroquia;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.ComboBox cboPropietario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private MaterialSkin.Controls.MaterialCheckBox cbxEstadoPropiedad;
        private MaterialSkin.Controls.MaterialLabel txtIdPropiedad;
        private System.Windows.Forms.ComboBox cboUsuarioPropiedad;
    }
}