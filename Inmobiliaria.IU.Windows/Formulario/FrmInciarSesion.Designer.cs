﻿
namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmInciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInciarSesion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuarioInicioSesion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContrasenaInicioSesion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnIniciarSesion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblUsuarioValidacion = new System.Windows.Forms.Label();
            this.lblContrasenaValidacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(266, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(266, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Contraseña";
            // 
            // txtUsuarioInicioSesion
            // 
            this.txtUsuarioInicioSesion.Depth = 0;
            this.txtUsuarioInicioSesion.Hint = "";
            this.txtUsuarioInicioSesion.Location = new System.Drawing.Point(269, 98);
            this.txtUsuarioInicioSesion.MaxLength = 32767;
            this.txtUsuarioInicioSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuarioInicioSesion.Name = "txtUsuarioInicioSesion";
            this.txtUsuarioInicioSesion.PasswordChar = '\0';
            this.txtUsuarioInicioSesion.SelectedText = "";
            this.txtUsuarioInicioSesion.SelectionLength = 0;
            this.txtUsuarioInicioSesion.SelectionStart = 0;
            this.txtUsuarioInicioSesion.Size = new System.Drawing.Size(149, 23);
            this.txtUsuarioInicioSesion.TabIndex = 3;
            this.txtUsuarioInicioSesion.TabStop = false;
            this.txtUsuarioInicioSesion.UseSystemPasswordChar = false;
            // 
            // txtContrasenaInicioSesion
            // 
            this.txtContrasenaInicioSesion.Depth = 0;
            this.txtContrasenaInicioSesion.Hint = "";
            this.txtContrasenaInicioSesion.Location = new System.Drawing.Point(269, 179);
            this.txtContrasenaInicioSesion.MaxLength = 32767;
            this.txtContrasenaInicioSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasenaInicioSesion.Name = "txtContrasenaInicioSesion";
            this.txtContrasenaInicioSesion.PasswordChar = '*';
            this.txtContrasenaInicioSesion.SelectedText = "";
            this.txtContrasenaInicioSesion.SelectionLength = 0;
            this.txtContrasenaInicioSesion.SelectionStart = 0;
            this.txtContrasenaInicioSesion.Size = new System.Drawing.Size(148, 23);
            this.txtContrasenaInicioSesion.TabIndex = 4;
            this.txtContrasenaInicioSesion.TabStop = false;
            this.txtContrasenaInicioSesion.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(204, 76);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 207);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSize = true;
            this.btnIniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarSesion.Depth = 0;
            this.btnIniciarSesion.Icon = null;
            this.btnIniciarSesion.Location = new System.Drawing.Point(284, 261);
            this.btnIniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Primary = true;
            this.btnIniciarSesion.Size = new System.Drawing.Size(120, 36);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblUsuarioValidacion
            // 
            this.lblUsuarioValidacion.AutoSize = true;
            this.lblUsuarioValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioValidacion.ForeColor = System.Drawing.Color.Red;
            this.lblUsuarioValidacion.Location = new System.Drawing.Point(267, 124);
            this.lblUsuarioValidacion.Name = "lblUsuarioValidacion";
            this.lblUsuarioValidacion.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioValidacion.TabIndex = 7;
            // 
            // lblContrasenaValidacion
            // 
            this.lblContrasenaValidacion.AutoSize = true;
            this.lblContrasenaValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaValidacion.ForeColor = System.Drawing.Color.Red;
            this.lblContrasenaValidacion.Location = new System.Drawing.Point(266, 205);
            this.lblContrasenaValidacion.Name = "lblContrasenaValidacion";
            this.lblContrasenaValidacion.Size = new System.Drawing.Size(0, 13);
            this.lblContrasenaValidacion.TabIndex = 8;
            // 
            // FrmInciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 309);
            this.Controls.Add(this.lblContrasenaValidacion);
            this.Controls.Add(this.lblUsuarioValidacion);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtContrasenaInicioSesion);
            this.Controls.Add(this.txtUsuarioInicioSesion);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuarioInicioSesion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenaInicioSesion;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btnIniciarSesion;
        private System.Windows.Forms.Label lblUsuarioValidacion;
        private System.Windows.Forms.Label lblContrasenaValidacion;
    }
}