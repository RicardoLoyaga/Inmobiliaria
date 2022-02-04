
namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmReporte
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
            this.dgvReportePropiedades = new System.Windows.Forms.DataGridView();
            this.txtParametroBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboTipoPropiedad = new System.Windows.Forms.ComboBox();
            this.lblTipoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportePropiedades
            // 
            this.dgvReportePropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePropiedades.Location = new System.Drawing.Point(29, 181);
            this.dgvReportePropiedades.Name = "dgvReportePropiedades";
            this.dgvReportePropiedades.Size = new System.Drawing.Size(875, 319);
            this.dgvReportePropiedades.TabIndex = 0;
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.Depth = 0;
            this.txtParametroBusqueda.Hint = "";
            this.txtParametroBusqueda.Location = new System.Drawing.Point(29, 139);
            this.txtParametroBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.PasswordChar = '\0';
            this.txtParametroBusqueda.SelectedText = "";
            this.txtParametroBusqueda.SelectionLength = 0;
            this.txtParametroBusqueda.SelectionStart = 0;
            this.txtParametroBusqueda.Size = new System.Drawing.Size(374, 23);
            this.txtParametroBusqueda.TabIndex = 1;
            this.txtParametroBusqueda.UseSystemPasswordChar = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(456, 139);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboTipoPropiedad
            // 
            this.cboTipoPropiedad.FormattingEnabled = true;
            this.cboTipoPropiedad.Location = new System.Drawing.Point(145, 95);
            this.cboTipoPropiedad.Name = "cboTipoPropiedad";
            this.cboTipoPropiedad.Size = new System.Drawing.Size(238, 21);
            this.cboTipoPropiedad.TabIndex = 3;
            this.cboTipoPropiedad.SelectedIndexChanged += new System.EventHandler(this.cboTipoPropiedad_SelectedIndexChanged);
            // 
            // lblTipoPropiedad
            // 
            this.lblTipoPropiedad.AutoSize = true;
            this.lblTipoPropiedad.Depth = 0;
            this.lblTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoPropiedad.Location = new System.Drawing.Point(25, 95);
            this.lblTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoPropiedad.Name = "lblTipoPropiedad";
            this.lblTipoPropiedad.Size = new System.Drawing.Size(114, 19);
            this.lblTipoPropiedad.TabIndex = 4;
            this.lblTipoPropiedad.Text = "Tipo Propiedad:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(466, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Provincia:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(547, 92);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(357, 21);
            this.cboProvincia.TabIndex = 6;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 549);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblTipoPropiedad);
            this.Controls.Add(this.cboTipoPropiedad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametroBusqueda);
            this.Controls.Add(this.dgvReportePropiedades);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportePropiedades;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtParametroBusqueda;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.ComboBox cboTipoPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblTipoPropiedad;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cboProvincia;
    }
}