namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmTipoPropiedad
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
            this.lblIdTipoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvTipoPropiedad = new System.Windows.Forms.DataGridView();
            this.txtTipoPropiedad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdTipoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoTipoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.cbxEstadoTipoPropiedad = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPropiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdTipoPropiedad
            // 
            this.lblIdTipoPropiedad.AutoSize = true;
            this.lblIdTipoPropiedad.Depth = 0;
            this.lblIdTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdTipoPropiedad.Location = new System.Drawing.Point(43, 107);
            this.lblIdTipoPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdTipoPropiedad.Name = "lblIdTipoPropiedad";
            this.lblIdTipoPropiedad.Size = new System.Drawing.Size(130, 19);
            this.lblIdTipoPropiedad.TabIndex = 17;
            this.lblIdTipoPropiedad.Text = "Id Tipo Propiedad:";
            // 
            // lblTipoPropiedad
            // 
            this.lblTipoPropiedad.AutoSize = true;
            this.lblTipoPropiedad.Depth = 0;
            this.lblTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoPropiedad.Location = new System.Drawing.Point(58, 137);
            this.lblTipoPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoPropiedad.Name = "lblTipoPropiedad";
            this.lblTipoPropiedad.Size = new System.Drawing.Size(114, 19);
            this.lblTipoPropiedad.TabIndex = 18;
            this.lblTipoPropiedad.Text = "Tipo Propiedad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(151, 222);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(91, 34);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(272, 222);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(91, 34);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvTipoPropiedad
            // 
            this.dgvTipoPropiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPropiedad.Location = new System.Drawing.Point(26, 293);
            this.dgvTipoPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTipoPropiedad.Name = "dgvTipoPropiedad";
            this.dgvTipoPropiedad.RowHeadersWidth = 62;
            this.dgvTipoPropiedad.RowTemplate.Height = 28;
            this.dgvTipoPropiedad.Size = new System.Drawing.Size(719, 203);
            this.dgvTipoPropiedad.TabIndex = 4;
            // 
            // txtTipoPropiedad
            // 
            this.txtTipoPropiedad.Depth = 0;
            this.txtTipoPropiedad.Hint = "";
            this.txtTipoPropiedad.Location = new System.Drawing.Point(176, 133);
            this.txtTipoPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTipoPropiedad.Name = "txtTipoPropiedad";
            this.txtTipoPropiedad.PasswordChar = '\0';
            this.txtTipoPropiedad.SelectedText = "";
            this.txtTipoPropiedad.SelectionLength = 0;
            this.txtTipoPropiedad.SelectionStart = 0;
            this.txtTipoPropiedad.Size = new System.Drawing.Size(225, 23);
            this.txtTipoPropiedad.TabIndex = 3;
            this.txtTipoPropiedad.UseSystemPasswordChar = false;
            // 
            // txtIdTipoPropiedad
            // 
            this.txtIdTipoPropiedad.AutoSize = true;
            this.txtIdTipoPropiedad.Depth = 0;
            this.txtIdTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtIdTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdTipoPropiedad.Location = new System.Drawing.Point(178, 107);
            this.txtIdTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdTipoPropiedad.Name = "txtIdTipoPropiedad";
            this.txtIdTipoPropiedad.Size = new System.Drawing.Size(0, 19);
            this.txtIdTipoPropiedad.TabIndex = 21;
            // 
            // lblEstadoTipoPropiedad
            // 
            this.lblEstadoTipoPropiedad.AutoSize = true;
            this.lblEstadoTipoPropiedad.Depth = 0;
            this.lblEstadoTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoTipoPropiedad.Location = new System.Drawing.Point(112, 165);
            this.lblEstadoTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoTipoPropiedad.Name = "lblEstadoTipoPropiedad";
            this.lblEstadoTipoPropiedad.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoTipoPropiedad.TabIndex = 22;
            this.lblEstadoTipoPropiedad.Text = "Estado:";
            // 
            // cbxEstadoTipoPropiedad
            // 
            this.cbxEstadoTipoPropiedad.AutoSize = true;
            this.cbxEstadoTipoPropiedad.Depth = 0;
            this.cbxEstadoTipoPropiedad.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxEstadoTipoPropiedad.Location = new System.Drawing.Point(175, 161);
            this.cbxEstadoTipoPropiedad.Margin = new System.Windows.Forms.Padding(0);
            this.cbxEstadoTipoPropiedad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxEstadoTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxEstadoTipoPropiedad.Name = "cbxEstadoTipoPropiedad";
            this.cbxEstadoTipoPropiedad.Ripple = true;
            this.cbxEstadoTipoPropiedad.Size = new System.Drawing.Size(69, 30);
            this.cbxEstadoTipoPropiedad.TabIndex = 23;
            this.cbxEstadoTipoPropiedad.Text = "Activo";
            this.cbxEstadoTipoPropiedad.UseVisualStyleBackColor = true;
            // 
            // FrmTipoPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 549);
            this.Controls.Add(this.cbxEstadoTipoPropiedad);
            this.Controls.Add(this.lblEstadoTipoPropiedad);
            this.Controls.Add(this.txtIdTipoPropiedad);
            this.Controls.Add(this.txtTipoPropiedad);
            this.Controls.Add(this.dgvTipoPropiedad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTipoPropiedad);
            this.Controls.Add(this.lblIdTipoPropiedad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTipoPropiedad";
            this.Text = "Tipo Propiedad";
            this.Load += new System.EventHandler(this.FrmTipoPropiedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPropiedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblIdTipoPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblTipoPropiedad;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.DataGridView dgvTipoPropiedad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTipoPropiedad;
        private MaterialSkin.Controls.MaterialLabel txtIdTipoPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblEstadoTipoPropiedad;
        private MaterialSkin.Controls.MaterialCheckBox cbxEstadoTipoPropiedad;
    }
}