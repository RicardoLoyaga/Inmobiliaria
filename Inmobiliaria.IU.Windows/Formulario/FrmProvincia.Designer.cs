
namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmProvincia
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
            this.lblIdProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.lblProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.TxtProvincia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvProvincias = new System.Windows.Forms.DataGridView();
            this.btnGuardarProvincia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelarProvincia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbxEstadoProvincia = new MaterialSkin.Controls.MaterialCheckBox();
            this.TxtIdProvincia = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProvincia
            // 
            this.lblIdProvincia.AutoSize = true;
            this.lblIdProvincia.Depth = 0;
            this.lblIdProvincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdProvincia.Location = new System.Drawing.Point(23, 99);
            this.lblIdProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdProvincia.Name = "lblIdProvincia";
            this.lblIdProvincia.Size = new System.Drawing.Size(95, 19);
            this.lblIdProvincia.TabIndex = 0;
            this.lblIdProvincia.Text = "Id Provincia: ";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Depth = 0;
            this.lblProvincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProvincia.Location = new System.Drawing.Point(39, 139);
            this.lblProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(79, 19);
            this.lblProvincia.TabIndex = 1;
            this.lblProvincia.Text = "Provincia: ";
            // 
            // lblEstadoProvincia
            // 
            this.lblEstadoProvincia.AutoSize = true;
            this.lblEstadoProvincia.Depth = 0;
            this.lblEstadoProvincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoProvincia.Location = new System.Drawing.Point(54, 183);
            this.lblEstadoProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoProvincia.Name = "lblEstadoProvincia";
            this.lblEstadoProvincia.Size = new System.Drawing.Size(64, 19);
            this.lblEstadoProvincia.TabIndex = 2;
            this.lblEstadoProvincia.Text = "Estado: ";
            // 
            // TxtProvincia
            // 
            this.TxtProvincia.Depth = 0;
            this.TxtProvincia.Hint = "";
            this.TxtProvincia.Location = new System.Drawing.Point(124, 135);
            this.TxtProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProvincia.Name = "TxtProvincia";
            this.TxtProvincia.PasswordChar = '\0';
            this.TxtProvincia.SelectedText = "";
            this.TxtProvincia.SelectionLength = 0;
            this.TxtProvincia.SelectionStart = 0;
            this.TxtProvincia.Size = new System.Drawing.Size(617, 23);
            this.TxtProvincia.TabIndex = 4;
            this.TxtProvincia.UseSystemPasswordChar = false;
            // 
            // dgvProvincias
            // 
            this.dgvProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincias.Location = new System.Drawing.Point(27, 219);
            this.dgvProvincias.Name = "dgvProvincias";
            this.dgvProvincias.Size = new System.Drawing.Size(714, 324);
            this.dgvProvincias.TabIndex = 6;
            this.dgvProvincias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvincias_CellDoubleClick);
            // 
            // btnGuardarProvincia
            // 
            this.btnGuardarProvincia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarProvincia.Depth = 0;
            this.btnGuardarProvincia.Location = new System.Drawing.Point(300, 183);
            this.btnGuardarProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarProvincia.Name = "btnGuardarProvincia";
            this.btnGuardarProvincia.Primary = true;
            this.btnGuardarProvincia.Size = new System.Drawing.Size(91, 30);
            this.btnGuardarProvincia.TabIndex = 10;
            this.btnGuardarProvincia.Text = "Guardar";
            this.btnGuardarProvincia.UseVisualStyleBackColor = true;
            this.btnGuardarProvincia.Click += new System.EventHandler(this.btnGuardarProvincia_Click);
            // 
            // btnCancelarProvincia
            // 
            this.btnCancelarProvincia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarProvincia.Depth = 0;
            this.btnCancelarProvincia.Location = new System.Drawing.Point(421, 183);
            this.btnCancelarProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarProvincia.Name = "btnCancelarProvincia";
            this.btnCancelarProvincia.Primary = true;
            this.btnCancelarProvincia.Size = new System.Drawing.Size(87, 30);
            this.btnCancelarProvincia.TabIndex = 11;
            this.btnCancelarProvincia.Text = "Cancelar";
            this.btnCancelarProvincia.UseVisualStyleBackColor = true;
            // 
            // cbxEstadoProvincia
            // 
            this.cbxEstadoProvincia.AutoSize = true;
            this.cbxEstadoProvincia.Depth = 0;
            this.cbxEstadoProvincia.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxEstadoProvincia.Location = new System.Drawing.Point(121, 179);
            this.cbxEstadoProvincia.Margin = new System.Windows.Forms.Padding(0);
            this.cbxEstadoProvincia.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxEstadoProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxEstadoProvincia.Name = "cbxEstadoProvincia";
            this.cbxEstadoProvincia.Ripple = true;
            this.cbxEstadoProvincia.Size = new System.Drawing.Size(69, 30);
            this.cbxEstadoProvincia.TabIndex = 12;
            this.cbxEstadoProvincia.Text = "Activo";
            this.cbxEstadoProvincia.UseVisualStyleBackColor = true;
            // 
            // TxtIdProvincia
            // 
            this.TxtIdProvincia.AutoSize = true;
            this.TxtIdProvincia.Depth = 0;
            this.TxtIdProvincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.TxtIdProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtIdProvincia.Location = new System.Drawing.Point(124, 99);
            this.TxtIdProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdProvincia.Name = "TxtIdProvincia";
            this.TxtIdProvincia.Size = new System.Drawing.Size(0, 19);
            this.TxtIdProvincia.TabIndex = 13;
            // 
            // FrmProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 549);
            this.Controls.Add(this.TxtIdProvincia);
            this.Controls.Add(this.cbxEstadoProvincia);
            this.Controls.Add(this.btnCancelarProvincia);
            this.Controls.Add(this.btnGuardarProvincia);
            this.Controls.Add(this.dgvProvincias);
            this.Controls.Add(this.TxtProvincia);
            this.Controls.Add(this.lblEstadoProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblIdProvincia);
            this.Name = "FrmProvincia";
            this.Text = "Información de Provincias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblIdProvincia;
        private MaterialSkin.Controls.MaterialLabel lblProvincia;
        private MaterialSkin.Controls.MaterialLabel lblEstadoProvincia;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProvincia;
        private System.Windows.Forms.DataGridView dgvProvincias;
        //private MaterialSkin.Controls.MaterialLabel TxtIdProvincia;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarProvincia;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelarProvincia;
        private MaterialSkin.Controls.MaterialCheckBox cbxEstadoProvincia;
        private MaterialSkin.Controls.MaterialLabel TxtIdProvincia;
    }
}