namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmCaracteristica
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
            this.lblIdCaracteristica = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCaracteristica = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardarCanton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblMetros = new MaterialSkin.Controls.MaterialLabel();
            this.lblNroPlantas = new MaterialSkin.Controls.MaterialLabel();
            this.txtMetros = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNroPlantas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNroBanios = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroBanios = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblHabitaciones = new MaterialSkin.Controls.MaterialLabel();
            this.txtHabitaciones = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblParqueaderos = new MaterialSkin.Controls.MaterialLabel();
            this.txtParqueaderos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblServicios = new MaterialSkin.Controls.MaterialLabel();
            this.txtServicios = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblOtros = new MaterialSkin.Controls.MaterialLabel();
            this.txtOtros = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvCaracteristica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCaracteristica
            // 
            this.lblIdCaracteristica.AutoSize = true;
            this.lblIdCaracteristica.Depth = 0;
            this.lblIdCaracteristica.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdCaracteristica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdCaracteristica.Location = new System.Drawing.Point(46, 112);
            this.lblIdCaracteristica.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdCaracteristica.Name = "lblIdCaracteristica";
            this.lblIdCaracteristica.Size = new System.Drawing.Size(175, 27);
            this.lblIdCaracteristica.TabIndex = 0;
            this.lblIdCaracteristica.Text = "Id Característica:";
            // 
            // txtIdCaracteristica
            // 
            this.txtIdCaracteristica.Depth = 0;
            this.txtIdCaracteristica.Hint = "";
            this.txtIdCaracteristica.Location = new System.Drawing.Point(236, 107);
            this.txtIdCaracteristica.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCaracteristica.Name = "txtIdCaracteristica";
            this.txtIdCaracteristica.PasswordChar = '\0';
            this.txtIdCaracteristica.SelectedText = "";
            this.txtIdCaracteristica.SelectionLength = 0;
            this.txtIdCaracteristica.SelectionStart = 0;
            this.txtIdCaracteristica.Size = new System.Drawing.Size(214, 32);
            this.txtIdCaracteristica.TabIndex = 1;
            this.txtIdCaracteristica.UseSystemPasswordChar = false;
            // 
            // btnGuardarCanton
            // 
            this.btnGuardarCanton.Depth = 0;
            this.btnGuardarCanton.Location = new System.Drawing.Point(348, 485);
            this.btnGuardarCanton.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCanton.Name = "btnGuardarCanton";
            this.btnGuardarCanton.Primary = true;
            this.btnGuardarCanton.Size = new System.Drawing.Size(137, 53);
            this.btnGuardarCanton.TabIndex = 3;
            this.btnGuardarCanton.Text = "Guardar";
            this.btnGuardarCanton.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(504, 485);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(137, 53);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Cancelar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Depth = 0;
            this.lblMetros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMetros.Location = new System.Drawing.Point(614, 116);
            this.lblMetros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(194, 27);
            this.lblMetros.TabIndex = 5;
            this.lblMetros.Text = "Metros cuadrados:";
            // 
            // lblNroPlantas
            // 
            this.lblNroPlantas.AutoSize = true;
            this.lblNroPlantas.Depth = 0;
            this.lblNroPlantas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroPlantas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroPlantas.Location = new System.Drawing.Point(90, 152);
            this.lblNroPlantas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroPlantas.Name = "lblNroPlantas";
            this.lblNroPlantas.Size = new System.Drawing.Size(131, 27);
            this.lblNroPlantas.TabIndex = 6;
            this.lblNroPlantas.Text = "Nro Plantas:";
            // 
            // txtMetros
            // 
            this.txtMetros.Depth = 0;
            this.txtMetros.Hint = "";
            this.txtMetros.Location = new System.Drawing.Point(814, 111);
            this.txtMetros.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.PasswordChar = '\0';
            this.txtMetros.SelectedText = "";
            this.txtMetros.SelectionLength = 0;
            this.txtMetros.SelectionStart = 0;
            this.txtMetros.Size = new System.Drawing.Size(95, 32);
            this.txtMetros.TabIndex = 2;
            this.txtMetros.UseSystemPasswordChar = false;
            // 
            // txtNroPlantas
            // 
            this.txtNroPlantas.Depth = 0;
            this.txtNroPlantas.Hint = "";
            this.txtNroPlantas.Location = new System.Drawing.Point(236, 148);
            this.txtNroPlantas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroPlantas.Name = "txtNroPlantas";
            this.txtNroPlantas.PasswordChar = '\0';
            this.txtNroPlantas.SelectedText = "";
            this.txtNroPlantas.SelectionLength = 0;
            this.txtNroPlantas.SelectionStart = 0;
            this.txtNroPlantas.Size = new System.Drawing.Size(95, 32);
            this.txtNroPlantas.TabIndex = 3;
            this.txtNroPlantas.UseSystemPasswordChar = false;
            // 
            // lblNroBanios
            // 
            this.lblNroBanios.AutoSize = true;
            this.lblNroBanios.Depth = 0;
            this.lblNroBanios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroBanios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroBanios.Location = new System.Drawing.Point(688, 156);
            this.lblNroBanios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroBanios.Name = "lblNroBanios";
            this.lblNroBanios.Size = new System.Drawing.Size(120, 27);
            this.lblNroBanios.TabIndex = 9;
            this.lblNroBanios.Text = "Nro Baños:";
            // 
            // txtNroBanios
            // 
            this.txtNroBanios.Depth = 0;
            this.txtNroBanios.Hint = "";
            this.txtNroBanios.Location = new System.Drawing.Point(814, 152);
            this.txtNroBanios.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroBanios.Name = "txtNroBanios";
            this.txtNroBanios.PasswordChar = '\0';
            this.txtNroBanios.SelectedText = "";
            this.txtNroBanios.SelectionLength = 0;
            this.txtNroBanios.SelectionStart = 0;
            this.txtNroBanios.Size = new System.Drawing.Size(95, 32);
            this.txtNroBanios.TabIndex = 4;
            this.txtNroBanios.UseSystemPasswordChar = false;
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Depth = 0;
            this.lblHabitaciones.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHabitaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHabitaciones.Location = new System.Drawing.Point(34, 192);
            this.lblHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(187, 27);
            this.lblHabitaciones.TabIndex = 11;
            this.lblHabitaciones.Text = "Nro Habitaciones:";
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Depth = 0;
            this.txtHabitaciones.Hint = "";
            this.txtHabitaciones.Location = new System.Drawing.Point(236, 189);
            this.txtHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.PasswordChar = '\0';
            this.txtHabitaciones.SelectedText = "";
            this.txtHabitaciones.SelectionLength = 0;
            this.txtHabitaciones.SelectionStart = 0;
            this.txtHabitaciones.Size = new System.Drawing.Size(95, 32);
            this.txtHabitaciones.TabIndex = 5;
            this.txtHabitaciones.UseSystemPasswordChar = false;
            // 
            // lblParqueaderos
            // 
            this.lblParqueaderos.AutoSize = true;
            this.lblParqueaderos.Depth = 0;
            this.lblParqueaderos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblParqueaderos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParqueaderos.Location = new System.Drawing.Point(613, 196);
            this.lblParqueaderos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblParqueaderos.Name = "lblParqueaderos";
            this.lblParqueaderos.Size = new System.Drawing.Size(195, 27);
            this.lblParqueaderos.TabIndex = 13;
            this.lblParqueaderos.Text = "Nro Parqueaderos:";
            // 
            // txtParqueaderos
            // 
            this.txtParqueaderos.Depth = 0;
            this.txtParqueaderos.Hint = "";
            this.txtParqueaderos.Location = new System.Drawing.Point(814, 190);
            this.txtParqueaderos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtParqueaderos.Name = "txtParqueaderos";
            this.txtParqueaderos.PasswordChar = '\0';
            this.txtParqueaderos.SelectedText = "";
            this.txtParqueaderos.SelectionLength = 0;
            this.txtParqueaderos.SelectionStart = 0;
            this.txtParqueaderos.Size = new System.Drawing.Size(95, 32);
            this.txtParqueaderos.TabIndex = 6;
            this.txtParqueaderos.UseSystemPasswordChar = false;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Depth = 0;
            this.lblServicios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblServicios.Location = new System.Drawing.Point(115, 231);
            this.lblServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(106, 27);
            this.lblServicios.TabIndex = 15;
            this.lblServicios.Text = "Servicios:";
            // 
            // txtServicios
            // 
            this.txtServicios.Depth = 0;
            this.txtServicios.Hint = "";
            this.txtServicios.Location = new System.Drawing.Point(236, 229);
            this.txtServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.PasswordChar = '\0';
            this.txtServicios.SelectedText = "";
            this.txtServicios.SelectionLength = 0;
            this.txtServicios.SelectionStart = 0;
            this.txtServicios.Size = new System.Drawing.Size(443, 32);
            this.txtServicios.TabIndex = 7;
            this.txtServicios.UseSystemPasswordChar = false;
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Depth = 0;
            this.lblOtros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOtros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOtros.Location = new System.Drawing.Point(738, 235);
            this.lblOtros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(70, 27);
            this.lblOtros.TabIndex = 17;
            this.lblOtros.Text = "Otros:";
            // 
            // txtOtros
            // 
            this.txtOtros.Depth = 0;
            this.txtOtros.Hint = "";
            this.txtOtros.Location = new System.Drawing.Point(814, 232);
            this.txtOtros.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.PasswordChar = '\0';
            this.txtOtros.SelectedText = "";
            this.txtOtros.SelectionLength = 0;
            this.txtOtros.SelectionStart = 0;
            this.txtOtros.Size = new System.Drawing.Size(95, 32);
            this.txtOtros.TabIndex = 8;
            this.txtOtros.UseSystemPasswordChar = false;
            // 
            // dgvCaracteristica
            // 
            this.dgvCaracteristica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristica.Location = new System.Drawing.Point(60, 290);
            this.dgvCaracteristica.Name = "dgvCaracteristica";
            this.dgvCaracteristica.RowHeadersWidth = 62;
            this.dgvCaracteristica.RowTemplate.Height = 28;
            this.dgvCaracteristica.Size = new System.Drawing.Size(863, 174);
            this.dgvCaracteristica.TabIndex = 9;
            // 
            // FrmCaracteristica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 564);
            this.Controls.Add(this.dgvCaracteristica);
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.lblOtros);
            this.Controls.Add(this.txtServicios);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.txtParqueaderos);
            this.Controls.Add(this.lblParqueaderos);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.txtNroBanios);
            this.Controls.Add(this.lblNroBanios);
            this.Controls.Add(this.txtNroPlantas);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.lblNroPlantas);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnGuardarCanton);
            this.Controls.Add(this.txtIdCaracteristica);
            this.Controls.Add(this.lblIdCaracteristica);
            this.Name = "FrmCaracteristica";
            this.Text = "Característica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblIdCaracteristica;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCaracteristica;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarCanton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel lblMetros;
        private MaterialSkin.Controls.MaterialLabel lblNroPlantas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMetros;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroPlantas;
        private MaterialSkin.Controls.MaterialLabel lblNroBanios;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroBanios;
        private MaterialSkin.Controls.MaterialLabel lblHabitaciones;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHabitaciones;
        private MaterialSkin.Controls.MaterialLabel lblParqueaderos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtParqueaderos;
        private MaterialSkin.Controls.MaterialLabel lblServicios;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServicios;
        private MaterialSkin.Controls.MaterialLabel lblOtros;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOtros;
        private System.Windows.Forms.DataGridView dgvCaracteristica;
    }
}