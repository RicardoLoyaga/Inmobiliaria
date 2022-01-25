
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
            this.txtIdRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEstadoRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdRol
            // 
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Depth = 0;
            this.lblIdRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdRol.Location = new System.Drawing.Point(52, 149);
            this.lblIdRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(77, 27);
            this.lblIdRol.TabIndex = 0;
            this.lblIdRol.Text = "Id Rol: ";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Depth = 0;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRol.Location = new System.Drawing.Point(76, 211);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(54, 27);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: ";
            // 
            // lblEstadoRol
            // 
            this.lblEstadoRol.AutoSize = true;
            this.lblEstadoRol.Depth = 0;
            this.lblEstadoRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoRol.Location = new System.Drawing.Point(39, 271);
            this.lblEstadoRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoRol.Name = "lblEstadoRol";
            this.lblEstadoRol.Size = new System.Drawing.Size(90, 27);
            this.lblEstadoRol.TabIndex = 2;
            this.lblEstadoRol.Text = "Estado: ";
            // 
            // txtIdRol
            // 
            this.txtIdRol.Depth = 0;
            this.txtIdRol.Hint = "";
            this.txtIdRol.Location = new System.Drawing.Point(144, 144);
            this.txtIdRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.PasswordChar = '\0';
            this.txtIdRol.SelectedText = "";
            this.txtIdRol.SelectionLength = 0;
            this.txtIdRol.SelectionStart = 0;
            this.txtIdRol.Size = new System.Drawing.Size(264, 32);
            this.txtIdRol.TabIndex = 3;
            this.txtIdRol.UseSystemPasswordChar = false;
            this.txtIdRol.Click += new System.EventHandler(this.txtIdRol_Click);
            // 
            // txtRol
            // 
            this.txtRol.Depth = 0;
            this.txtRol.Hint = "";
            this.txtRol.Location = new System.Drawing.Point(144, 206);
            this.txtRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.SelectedText = "";
            this.txtRol.SelectionLength = 0;
            this.txtRol.SelectionStart = 0;
            this.txtRol.Size = new System.Drawing.Size(264, 32);
            this.txtRol.TabIndex = 4;
            this.txtRol.UseSystemPasswordChar = false;
            // 
            // txtEstadoRol
            // 
            this.txtEstadoRol.Depth = 0;
            this.txtEstadoRol.Hint = "";
            this.txtEstadoRol.Location = new System.Drawing.Point(144, 265);
            this.txtEstadoRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstadoRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstadoRol.Name = "txtEstadoRol";
            this.txtEstadoRol.PasswordChar = '\0';
            this.txtEstadoRol.SelectedText = "";
            this.txtEstadoRol.SelectionLength = 0;
            this.txtEstadoRol.SelectionStart = 0;
            this.txtEstadoRol.Size = new System.Drawing.Size(264, 32);
            this.txtEstadoRol.TabIndex = 5;
            this.txtEstadoRol.UseSystemPasswordChar = false;
            // 
            // dgvRol
            // 
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Location = new System.Drawing.Point(516, 112);
            this.dgvRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.RowHeadersWidth = 62;
            this.dgvRol.Size = new System.Drawing.Size(642, 348);
            this.dgvRol.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(82, 354);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(112, 46);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(258, 354);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(112, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 478);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvRol);
            this.Controls.Add(this.txtEstadoRol);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.lblEstadoRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblIdRol);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}