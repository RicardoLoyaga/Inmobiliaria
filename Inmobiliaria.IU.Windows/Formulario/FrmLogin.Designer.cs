
namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmLogin
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
            this.lblIdLogin = new MaterialSkin.Controls.MaterialLabel();
            this.lblIdRolLogin = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuarioLogin = new MaterialSkin.Controls.MaterialLabel();
            this.lblConstrasenaLogin = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoLogin = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuarioLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContrasenaLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEstadoLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardarLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelarLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboRolLogin = new System.Windows.Forms.ComboBox();
            this.dgvSeguridades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguridades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdLogin
            // 
            this.lblIdLogin.AutoSize = true;
            this.lblIdLogin.Depth = 0;
            this.lblIdLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdLogin.Location = new System.Drawing.Point(36, 85);
            this.lblIdLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdLogin.Name = "lblIdLogin";
            this.lblIdLogin.Size = new System.Drawing.Size(70, 19);
            this.lblIdLogin.TabIndex = 0;
            this.lblIdLogin.Text = "Id Login: ";
            // 
            // lblIdRolLogin
            // 
            this.lblIdRolLogin.AutoSize = true;
            this.lblIdRolLogin.Depth = 0;
            this.lblIdRolLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdRolLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdRolLogin.Location = new System.Drawing.Point(67, 118);
            this.lblIdRolLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdRolLogin.Name = "lblIdRolLogin";
            this.lblIdRolLogin.Size = new System.Drawing.Size(39, 19);
            this.lblIdRolLogin.TabIndex = 1;
            this.lblIdRolLogin.Text = "Rol: ";
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Depth = 0;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuarioLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuarioLogin.Location = new System.Drawing.Point(41, 153);
            this.lblUsuarioLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(65, 19);
            this.lblUsuarioLogin.TabIndex = 2;
            this.lblUsuarioLogin.Text = "Usuario:";
            // 
            // lblConstrasenaLogin
            // 
            this.lblConstrasenaLogin.AutoSize = true;
            this.lblConstrasenaLogin.Depth = 0;
            this.lblConstrasenaLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConstrasenaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConstrasenaLogin.Location = new System.Drawing.Point(12, 184);
            this.lblConstrasenaLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConstrasenaLogin.Name = "lblConstrasenaLogin";
            this.lblConstrasenaLogin.Size = new System.Drawing.Size(94, 19);
            this.lblConstrasenaLogin.TabIndex = 3;
            this.lblConstrasenaLogin.Text = "Contraseña: ";
            // 
            // lblEstadoLogin
            // 
            this.lblEstadoLogin.AutoSize = true;
            this.lblEstadoLogin.Depth = 0;
            this.lblEstadoLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoLogin.Location = new System.Drawing.Point(46, 218);
            this.lblEstadoLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoLogin.Name = "lblEstadoLogin";
            this.lblEstadoLogin.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoLogin.TabIndex = 4;
            this.lblEstadoLogin.Text = "Estado:";
            // 
            // txtIdLogin
            // 
            this.txtIdLogin.Depth = 0;
            this.txtIdLogin.Hint = "";
            this.txtIdLogin.Location = new System.Drawing.Point(113, 80);
            this.txtIdLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdLogin.Name = "txtIdLogin";
            this.txtIdLogin.PasswordChar = '\0';
            this.txtIdLogin.SelectedText = "";
            this.txtIdLogin.SelectionLength = 0;
            this.txtIdLogin.SelectionStart = 0;
            this.txtIdLogin.Size = new System.Drawing.Size(147, 23);
            this.txtIdLogin.TabIndex = 5;
            this.txtIdLogin.UseSystemPasswordChar = false;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Depth = 0;
            this.txtUsuarioLogin.Hint = "";
            this.txtUsuarioLogin.Location = new System.Drawing.Point(113, 149);
            this.txtUsuarioLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.PasswordChar = '\0';
            this.txtUsuarioLogin.SelectedText = "";
            this.txtUsuarioLogin.SelectionLength = 0;
            this.txtUsuarioLogin.SelectionStart = 0;
            this.txtUsuarioLogin.Size = new System.Drawing.Size(147, 23);
            this.txtUsuarioLogin.TabIndex = 6;
            this.txtUsuarioLogin.UseSystemPasswordChar = false;
            // 
            // txtContrasenaLogin
            // 
            this.txtContrasenaLogin.Depth = 0;
            this.txtContrasenaLogin.Hint = "";
            this.txtContrasenaLogin.Location = new System.Drawing.Point(113, 179);
            this.txtContrasenaLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasenaLogin.Name = "txtContrasenaLogin";
            this.txtContrasenaLogin.PasswordChar = '*';
            this.txtContrasenaLogin.SelectedText = "";
            this.txtContrasenaLogin.SelectionLength = 0;
            this.txtContrasenaLogin.SelectionStart = 0;
            this.txtContrasenaLogin.Size = new System.Drawing.Size(147, 23);
            this.txtContrasenaLogin.TabIndex = 7;
            this.txtContrasenaLogin.UseSystemPasswordChar = false;
            // 
            // txtEstadoLogin
            // 
            this.txtEstadoLogin.Depth = 0;
            this.txtEstadoLogin.Hint = "";
            this.txtEstadoLogin.Location = new System.Drawing.Point(113, 213);
            this.txtEstadoLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstadoLogin.Name = "txtEstadoLogin";
            this.txtEstadoLogin.PasswordChar = '\0';
            this.txtEstadoLogin.SelectedText = "";
            this.txtEstadoLogin.SelectionLength = 0;
            this.txtEstadoLogin.SelectionStart = 0;
            this.txtEstadoLogin.Size = new System.Drawing.Size(147, 23);
            this.txtEstadoLogin.TabIndex = 8;
            this.txtEstadoLogin.UseSystemPasswordChar = false;
            // 
            // btnGuardarLogin
            // 
            this.btnGuardarLogin.Depth = 0;
            this.btnGuardarLogin.Location = new System.Drawing.Point(50, 267);
            this.btnGuardarLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarLogin.Name = "btnGuardarLogin";
            this.btnGuardarLogin.Primary = true;
            this.btnGuardarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarLogin.TabIndex = 9;
            this.btnGuardarLogin.Text = "Guardar";
            this.btnGuardarLogin.UseVisualStyleBackColor = true;
            this.btnGuardarLogin.Click += new System.EventHandler(this.btnGuardarLogin_Click);
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.Depth = 0;
            this.btnCancelarLogin.Location = new System.Drawing.Point(163, 267);
            this.btnCancelarLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Primary = true;
            this.btnCancelarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarLogin.TabIndex = 10;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = true;
            this.btnCancelarLogin.Click += new System.EventHandler(this.btnCancelarLogin_Click);
            // 
            // cboRolLogin
            // 
            this.cboRolLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cboRolLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboRolLogin.FormattingEnabled = true;
            this.cboRolLogin.Location = new System.Drawing.Point(113, 115);
            this.cboRolLogin.Name = "cboRolLogin";
            this.cboRolLogin.Size = new System.Drawing.Size(147, 21);
            this.cboRolLogin.TabIndex = 11;
            this.cboRolLogin.SelectedIndexChanged += new System.EventHandler(this.cboRolLogin_SelectedIndexChanged);
            // 
            // dgvSeguridades
            // 
            this.dgvSeguridades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguridades.Location = new System.Drawing.Point(288, 80);
            this.dgvSeguridades.Name = "dgvSeguridades";
            this.dgvSeguridades.Size = new System.Drawing.Size(484, 219);
            this.dgvSeguridades.TabIndex = 12;
            this.dgvSeguridades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeguridades_CellContentClick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.dgvSeguridades);
            this.Controls.Add(this.cboRolLogin);
            this.Controls.Add(this.btnCancelarLogin);
            this.Controls.Add(this.btnGuardarLogin);
            this.Controls.Add(this.txtEstadoLogin);
            this.Controls.Add(this.txtContrasenaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.txtIdLogin);
            this.Controls.Add(this.lblEstadoLogin);
            this.Controls.Add(this.lblConstrasenaLogin);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.lblIdRolLogin);
            this.Controls.Add(this.lblIdLogin);
            this.Name = "FrmLogin";
            this.Text = "Módulo Seguridades";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguridades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblIdLogin;
        private MaterialSkin.Controls.MaterialLabel lblIdRolLogin;
        private MaterialSkin.Controls.MaterialLabel lblUsuarioLogin;
        private MaterialSkin.Controls.MaterialLabel lblConstrasenaLogin;
        private MaterialSkin.Controls.MaterialLabel lblEstadoLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuarioLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenaLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstadoLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelarLogin;
        private System.Windows.Forms.ComboBox cboRolLogin;
        private System.Windows.Forms.DataGridView dgvSeguridades;
    }
}