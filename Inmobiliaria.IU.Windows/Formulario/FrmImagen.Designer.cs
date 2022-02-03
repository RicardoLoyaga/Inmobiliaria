namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmImagen
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
            this.lblmagen = new MaterialSkin.Controls.MaterialLabel();
            this.lblPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxEstadoImagen = new System.Windows.Forms.CheckBox();
            this.btnGuardarImagen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelarImagen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdInformaciónImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPath = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmagen
            // 
            this.lblmagen.Depth = 0;
            this.lblmagen.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblmagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblmagen.Location = new System.Drawing.Point(12, 72);
            this.lblmagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblmagen.Name = "lblmagen";
            this.lblmagen.Size = new System.Drawing.Size(36, 19);
            this.lblmagen.TabIndex = 1;
            this.lblmagen.Text = "Id:";
            this.lblmagen.Click += new System.EventHandler(this.lblmagen_Click);
            // 
            // lblPropiedad
            // 
            this.lblPropiedad.Depth = 0;
            this.lblPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPropiedad.Location = new System.Drawing.Point(215, 76);
            this.lblPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPropiedad.Name = "lblPropiedad";
            this.lblPropiedad.Size = new System.Drawing.Size(90, 19);
            this.lblPropiedad.TabIndex = 5;
            this.lblPropiedad.Text = "Propiedad: ";
            // 
            // lblEstado
            // 
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstado.Location = new System.Drawing.Point(215, 116);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 19);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado: ";
            // 
            // dgvImagen
            // 
            this.dgvImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagen.Location = new System.Drawing.Point(16, 143);
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.Size = new System.Drawing.Size(772, 117);
            this.dgvImagen.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // cbxEstadoImagen
            // 
            this.cbxEstadoImagen.AutoSize = true;
            this.cbxEstadoImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoImagen.Location = new System.Drawing.Point(311, 116);
            this.cbxEstadoImagen.Name = "cbxEstadoImagen";
            this.cbxEstadoImagen.Size = new System.Drawing.Size(65, 21);
            this.cbxEstadoImagen.TabIndex = 26;
            this.cbxEstadoImagen.Text = "Activo";
            this.cbxEstadoImagen.UseVisualStyleBackColor = true;
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.Depth = 0;
            this.btnGuardarImagen.Location = new System.Drawing.Point(260, 276);
            this.btnGuardarImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Primary = true;
            this.btnGuardarImagen.Size = new System.Drawing.Size(82, 36);
            this.btnGuardarImagen.TabIndex = 27;
            this.btnGuardarImagen.Text = "Guardar";
            this.btnGuardarImagen.UseVisualStyleBackColor = true;
            // 
            // btnCancelarImagen
            // 
            this.btnCancelarImagen.Depth = 0;
            this.btnCancelarImagen.Location = new System.Drawing.Point(434, 276);
            this.btnCancelarImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarImagen.Name = "btnCancelarImagen";
            this.btnCancelarImagen.Primary = true;
            this.btnCancelarImagen.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarImagen.TabIndex = 28;
            this.btnCancelarImagen.Text = "Cancelar";
            this.btnCancelarImagen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Agregar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtIdInformaciónImagen
            // 
            this.txtIdInformaciónImagen.Depth = 0;
            this.txtIdInformaciónImagen.Hint = "";
            this.txtIdInformaciónImagen.Location = new System.Drawing.Point(57, 72);
            this.txtIdInformaciónImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdInformaciónImagen.Name = "txtIdInformaciónImagen";
            this.txtIdInformaciónImagen.PasswordChar = '\0';
            this.txtIdInformaciónImagen.SelectedText = "";
            this.txtIdInformaciónImagen.SelectionLength = 0;
            this.txtIdInformaciónImagen.SelectionStart = 0;
            this.txtIdInformaciónImagen.Size = new System.Drawing.Size(135, 23);
            this.txtIdInformaciónImagen.TabIndex = 30;
            this.txtIdInformaciónImagen.UseSystemPasswordChar = false;
            // 
            // lblPath
            // 
            this.lblPath.Depth = 0;
            this.lblPath.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPath.Location = new System.Drawing.Point(12, 112);
            this.lblPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(45, 19);
            this.lblPath.TabIndex = 31;
            this.lblPath.Text = "Path:";
            // 
            // FrmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtIdInformaciónImagen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelarImagen);
            this.Controls.Add(this.btnGuardarImagen);
            this.Controls.Add(this.cbxEstadoImagen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvImagen);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPropiedad);
            this.Controls.Add(this.lblmagen);
            this.Name = "FrmImagen";
            this.Text = "Información Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblmagen;
        private MaterialSkin.Controls.MaterialLabel lblPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblEstado;
        private System.Windows.Forms.DataGridView dgvImagen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cbxEstadoImagen;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarImagen;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelarImagen;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdInformaciónImagen;
        private MaterialSkin.Controls.MaterialLabel lblPath;
    }
}