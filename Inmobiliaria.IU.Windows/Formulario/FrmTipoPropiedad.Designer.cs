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
            this.txtIdTipoPropiedad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTipoPropiedad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPropiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdTipoPropiedad
            // 
            this.lblIdTipoPropiedad.AutoSize = true;
            this.lblIdTipoPropiedad.Depth = 0;
            this.lblIdTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdTipoPropiedad.Location = new System.Drawing.Point(44, 75);
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
            this.lblTipoPropiedad.Location = new System.Drawing.Point(59, 105);
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
            this.btnGuardar.Location = new System.Drawing.Point(149, 244);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnCancelar.Location = new System.Drawing.Point(251, 244);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dgvTipoPropiedad.Location = new System.Drawing.Point(43, 146);
            this.dgvTipoPropiedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTipoPropiedad.Name = "dgvTipoPropiedad";
            this.dgvTipoPropiedad.RowHeadersWidth = 62;
            this.dgvTipoPropiedad.RowTemplate.Height = 28;
            this.dgvTipoPropiedad.Size = new System.Drawing.Size(407, 84);
            this.dgvTipoPropiedad.TabIndex = 4;
            // 
            // txtIdTipoPropiedad
            // 
            this.txtIdTipoPropiedad.Depth = 0;
            this.txtIdTipoPropiedad.Hint = "";
            this.txtIdTipoPropiedad.Location = new System.Drawing.Point(173, 71);
            this.txtIdTipoPropiedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdTipoPropiedad.Name = "txtIdTipoPropiedad";
            this.txtIdTipoPropiedad.PasswordChar = '\0';
            this.txtIdTipoPropiedad.SelectedText = "";
            this.txtIdTipoPropiedad.SelectionLength = 0;
            this.txtIdTipoPropiedad.SelectionStart = 0;
            this.txtIdTipoPropiedad.Size = new System.Drawing.Size(76, 23);
            this.txtIdTipoPropiedad.TabIndex = 2;
            this.txtIdTipoPropiedad.UseSystemPasswordChar = false;
            // 
            // txtTipoPropiedad
            // 
            this.txtTipoPropiedad.Depth = 0;
            this.txtTipoPropiedad.Hint = "";
            this.txtTipoPropiedad.Location = new System.Drawing.Point(173, 103);
            this.txtTipoPropiedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // FrmTipoPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 300);
            this.Controls.Add(this.txtTipoPropiedad);
            this.Controls.Add(this.txtIdTipoPropiedad);
            this.Controls.Add(this.dgvTipoPropiedad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTipoPropiedad);
            this.Controls.Add(this.lblIdTipoPropiedad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdTipoPropiedad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTipoPropiedad;
    }
}