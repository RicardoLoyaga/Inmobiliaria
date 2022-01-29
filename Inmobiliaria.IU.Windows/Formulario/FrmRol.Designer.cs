
namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmRol
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
            this.lblIdRol = new MaterialSkin.Controls.MaterialLabel();
            this.lblRol = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoRol = new MaterialSkin.Controls.MaterialLabel();
            this.txtRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbxEstadoRol = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtIdRol2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdRol
            // 
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Depth = 0;
            this.lblIdRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdRol.Location = new System.Drawing.Point(35, 97);
            this.lblIdRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(55, 19);
            this.lblIdRol.TabIndex = 0;
            this.lblIdRol.Text = "Id Rol: ";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Depth = 0;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRol.Location = new System.Drawing.Point(51, 137);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 19);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: ";
            // 
            // lblEstadoRol
            // 
            this.lblEstadoRol.AutoSize = true;
            this.lblEstadoRol.Depth = 0;
            this.lblEstadoRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoRol.Location = new System.Drawing.Point(26, 176);
            this.lblEstadoRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoRol.Name = "lblEstadoRol";
            this.lblEstadoRol.Size = new System.Drawing.Size(64, 19);
            this.lblEstadoRol.TabIndex = 2;
            this.lblEstadoRol.Text = "Estado: ";
            // 
            // txtRol
            // 
            this.txtRol.Depth = 0;
            this.txtRol.Hint = "";
            this.txtRol.Location = new System.Drawing.Point(96, 134);
            this.txtRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.SelectedText = "";
            this.txtRol.SelectionLength = 0;
            this.txtRol.SelectionStart = 0;
            this.txtRol.Size = new System.Drawing.Size(176, 23);
            this.txtRol.TabIndex = 4;
            this.txtRol.UseSystemPasswordChar = false;
            // 
            // dgvRol
            // 
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Location = new System.Drawing.Point(344, 73);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.RowHeadersWidth = 62;
            this.dgvRol.Size = new System.Drawing.Size(428, 226);
            this.dgvRol.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(55, 230);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(172, 230);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxEstadoRol
            // 
            this.cbxEstadoRol.AutoSize = true;
            this.cbxEstadoRol.Depth = 0;
            this.cbxEstadoRol.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxEstadoRol.Location = new System.Drawing.Point(97, 172);
            this.cbxEstadoRol.Margin = new System.Windows.Forms.Padding(0);
            this.cbxEstadoRol.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxEstadoRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxEstadoRol.Name = "cbxEstadoRol";
            this.cbxEstadoRol.Ripple = true;
            this.cbxEstadoRol.Size = new System.Drawing.Size(69, 30);
            this.cbxEstadoRol.TabIndex = 10;
            this.cbxEstadoRol.Text = "Activo";
            this.cbxEstadoRol.UseVisualStyleBackColor = true;
            // 
            // txtIdRol2
            // 
            this.txtIdRol2.AutoSize = true;
            this.txtIdRol2.Depth = 0;
            this.txtIdRol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdRol2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdRol2.Location = new System.Drawing.Point(111, 100);
            this.txtIdRol2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdRol2.Name = "txtIdRol2";
            this.txtIdRol2.Size = new System.Drawing.Size(0, 18);
            this.txtIdRol2.TabIndex = 11;
            // 
            // FrmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.txtIdRol2);
            this.Controls.Add(this.cbxEstadoRol);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvRol);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.lblEstadoRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblIdRol);
            this.Name = "FrmRol";
            this.Text = "Información de Roles";
            this.Load += new System.EventHandler(this.FrmRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblIdRol;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MaterialSkin.Controls.MaterialLabel lblEstadoRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstadoRol;
        private System.Windows.Forms.DataGridView dgvRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        //private MaterialSkin.Controls.MaterialLabel txtIdRol;
        private MaterialSkin.Controls.MaterialCheckBox cbxEstadoRol;
        private MaterialSkin.Controls.MaterialLabel txtIdRol2;
    }
}