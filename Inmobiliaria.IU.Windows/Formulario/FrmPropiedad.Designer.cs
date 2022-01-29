namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmPropiedad
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
            this.lblIdPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.dgvPropiedad = new System.Windows.Forms.DataGridView();
            this.btnGuardarPropiedad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboTipoPropiedad = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.lblCanton = new MaterialSkin.Controls.MaterialLabel();
            this.lblParroquia = new MaterialSkin.Controls.MaterialLabel();
            this.lblBarrio = new MaterialSkin.Controls.MaterialLabel();
            this.cboCanton = new System.Windows.Forms.ComboBox();
            this.cboParroquia = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbxEstadoPropiedad = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtIdPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCallePrincipal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCalleSecundaria = new MaterialSkin.Controls.MaterialLabel();
            this.txtCalleSecundaria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtOtros = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblOtros = new MaterialSkin.Controls.MaterialLabel();
            this.txtServicios = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblServicios = new MaterialSkin.Controls.MaterialLabel();
            this.txtParqueaderos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblParqueaderos = new MaterialSkin.Controls.MaterialLabel();
            this.txtHabitaciones = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblHabitaciones = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroBanios = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNroBanios = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroPlantas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMetros = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNroPlantas = new MaterialSkin.Controls.MaterialLabel();
            this.lblMetros = new MaterialSkin.Controls.MaterialLabel();
            this.lblFotoPrincipal = new MaterialSkin.Controls.MaterialLabel();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPropiedad
            // 
            this.lblIdPropiedad.AutoSize = true;
            this.lblIdPropiedad.Depth = 0;
            this.lblIdPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdPropiedad.Location = new System.Drawing.Point(32, 316);
            this.lblIdPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdPropiedad.Name = "lblIdPropiedad";
            this.lblIdPropiedad.Size = new System.Drawing.Size(96, 19);
            this.lblIdPropiedad.TabIndex = 0;
            this.lblIdPropiedad.Text = "Id Propiedad:";
            // 
            // lblTipoPropiedad
            // 
            this.lblTipoPropiedad.AutoSize = true;
            this.lblTipoPropiedad.Depth = 0;
            this.lblTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoPropiedad.Location = new System.Drawing.Point(386, 316);
            this.lblTipoPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoPropiedad.Name = "lblTipoPropiedad";
            this.lblTipoPropiedad.Size = new System.Drawing.Size(114, 19);
            this.lblTipoPropiedad.TabIndex = 2;
            this.lblTipoPropiedad.Text = "Tipo Propiedad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Depth = 0;
            this.lblProvincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProvincia.Location = new System.Drawing.Point(32, 100);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(75, 19);
            this.lblProvincia.TabIndex = 3;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Depth = 0;
            this.lblPrecio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecio.Location = new System.Drawing.Point(32, 214);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 19);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblEstadoPropiedad
            // 
            this.lblEstadoPropiedad.AutoSize = true;
            this.lblEstadoPropiedad.Depth = 0;
            this.lblEstadoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoPropiedad.Location = new System.Drawing.Point(107, 471);
            this.lblEstadoPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoPropiedad.Name = "lblEstadoPropiedad";
            this.lblEstadoPropiedad.Size = new System.Drawing.Size(60, 19);
            this.lblEstadoPropiedad.TabIndex = 6;
            this.lblEstadoPropiedad.Text = "Estado:";
            // 
            // dgvPropiedad
            // 
            this.dgvPropiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedad.Location = new System.Drawing.Point(36, 522);
            this.dgvPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPropiedad.Name = "dgvPropiedad";
            this.dgvPropiedad.RowHeadersWidth = 62;
            this.dgvPropiedad.RowTemplate.Height = 28;
            this.dgvPropiedad.Size = new System.Drawing.Size(731, 132);
            this.dgvPropiedad.TabIndex = 12;
            // 
            // btnGuardarPropiedad
            // 
            this.btnGuardarPropiedad.Depth = 0;
            this.btnGuardarPropiedad.Location = new System.Drawing.Point(326, 471);
            this.btnGuardarPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            this.btnGuardarPropiedad.Primary = true;
            this.btnGuardarPropiedad.Size = new System.Drawing.Size(91, 34);
            this.btnGuardarPropiedad.TabIndex = 9;
            this.btnGuardarPropiedad.Text = "Guardar";
            this.btnGuardarPropiedad.UseVisualStyleBackColor = true;
            this.btnGuardarPropiedad.Click += new System.EventHandler(this.btnGuardarPropiedad_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(472, 471);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(91, 34);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTipoPropiedad
            // 
            this.cboTipoPropiedad.FormattingEnabled = true;
            this.cboTipoPropiedad.Location = new System.Drawing.Point(515, 314);
            this.cboTipoPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoPropiedad.Name = "cboTipoPropiedad";
            this.cboTipoPropiedad.Size = new System.Drawing.Size(249, 21);
            this.cboTipoPropiedad.TabIndex = 3;
            // 
            // cboProvincia
            // 
            this.cboProvincia.BackColor = System.Drawing.SystemColors.Window;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(119, 101);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(275, 21);
            this.cboProvincia.TabIndex = 5;
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Depth = 0;
            this.lblCanton.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCanton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCanton.Location = new System.Drawing.Point(435, 100);
            this.lblCanton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanton.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(61, 19);
            this.lblCanton.TabIndex = 16;
            this.lblCanton.Text = "Cantón:";
            // 
            // lblParroquia
            // 
            this.lblParroquia.AutoSize = true;
            this.lblParroquia.Depth = 0;
            this.lblParroquia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblParroquia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParroquia.Location = new System.Drawing.Point(29, 127);
            this.lblParroquia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblParroquia.Name = "lblParroquia";
            this.lblParroquia.Size = new System.Drawing.Size(78, 19);
            this.lblParroquia.TabIndex = 17;
            this.lblParroquia.Text = "Parroquia:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Depth = 0;
            this.lblBarrio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBarrio.Location = new System.Drawing.Point(443, 128);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(53, 19);
            this.lblBarrio.TabIndex = 18;
            this.lblBarrio.Text = "Barrio:";
            // 
            // cboCanton
            // 
            this.cboCanton.BackColor = System.Drawing.SystemColors.Window;
            this.cboCanton.FormattingEnabled = true;
            this.cboCanton.Location = new System.Drawing.Point(503, 101);
            this.cboCanton.Margin = new System.Windows.Forms.Padding(2);
            this.cboCanton.Name = "cboCanton";
            this.cboCanton.Size = new System.Drawing.Size(261, 21);
            this.cboCanton.TabIndex = 6;
            // 
            // cboParroquia
            // 
            this.cboParroquia.BackColor = System.Drawing.SystemColors.Window;
            this.cboParroquia.FormattingEnabled = true;
            this.cboParroquia.Location = new System.Drawing.Point(119, 127);
            this.cboParroquia.Margin = new System.Windows.Forms.Padding(2);
            this.cboParroquia.Name = "cboParroquia";
            this.cboParroquia.Size = new System.Drawing.Size(275, 21);
            this.cboParroquia.TabIndex = 7;
            // 
            // cboBarrio
            // 
            this.cboBarrio.BackColor = System.Drawing.SystemColors.Window;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(503, 128);
            this.cboBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(261, 21);
            this.cboBarrio.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "";
            this.txtPrecio.Location = new System.Drawing.Point(92, 210);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(216, 23);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // cbxEstadoPropiedad
            // 
            this.cbxEstadoPropiedad.AutoSize = true;
            this.cbxEstadoPropiedad.Depth = 0;
            this.cbxEstadoPropiedad.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxEstadoPropiedad.Location = new System.Drawing.Point(177, 467);
            this.cbxEstadoPropiedad.Margin = new System.Windows.Forms.Padding(0);
            this.cbxEstadoPropiedad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxEstadoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxEstadoPropiedad.Name = "cbxEstadoPropiedad";
            this.cbxEstadoPropiedad.Ripple = true;
            this.cbxEstadoPropiedad.Size = new System.Drawing.Size(69, 30);
            this.cbxEstadoPropiedad.TabIndex = 19;
            this.cbxEstadoPropiedad.Text = "Activo";
            this.cbxEstadoPropiedad.UseVisualStyleBackColor = true;
            // 
            // txtIdPropiedad
            // 
            this.txtIdPropiedad.AutoSize = true;
            this.txtIdPropiedad.Depth = 0;
            this.txtIdPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtIdPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdPropiedad.Location = new System.Drawing.Point(151, 318);
            this.txtIdPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdPropiedad.Name = "txtIdPropiedad";
            this.txtIdPropiedad.Size = new System.Drawing.Size(0, 19);
            this.txtIdPropiedad.TabIndex = 20;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(346, 68);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Datos Generales";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(29, 159);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Calle Principal:";
            // 
            // txtCallePrincipal
            // 
            this.txtCallePrincipal.Depth = 0;
            this.txtCallePrincipal.Hint = "";
            this.txtCallePrincipal.Location = new System.Drawing.Point(146, 155);
            this.txtCallePrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCallePrincipal.Name = "txtCallePrincipal";
            this.txtCallePrincipal.PasswordChar = '\0';
            this.txtCallePrincipal.SelectedText = "";
            this.txtCallePrincipal.SelectionLength = 0;
            this.txtCallePrincipal.SelectionStart = 0;
            this.txtCallePrincipal.Size = new System.Drawing.Size(618, 23);
            this.txtCallePrincipal.TabIndex = 24;
            this.txtCallePrincipal.UseSystemPasswordChar = false;
            // 
            // lblCalleSecundaria
            // 
            this.lblCalleSecundaria.AutoSize = true;
            this.lblCalleSecundaria.Depth = 0;
            this.lblCalleSecundaria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCalleSecundaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCalleSecundaria.Location = new System.Drawing.Point(30, 187);
            this.lblCalleSecundaria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCalleSecundaria.Name = "lblCalleSecundaria";
            this.lblCalleSecundaria.Size = new System.Drawing.Size(125, 19);
            this.lblCalleSecundaria.TabIndex = 25;
            this.lblCalleSecundaria.Text = "Calle Secundaria:";
            // 
            // txtCalleSecundaria
            // 
            this.txtCalleSecundaria.Depth = 0;
            this.txtCalleSecundaria.Hint = "";
            this.txtCalleSecundaria.Location = new System.Drawing.Point(159, 182);
            this.txtCalleSecundaria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCalleSecundaria.Name = "txtCalleSecundaria";
            this.txtCalleSecundaria.PasswordChar = '\0';
            this.txtCalleSecundaria.SelectedText = "";
            this.txtCalleSecundaria.SelectionLength = 0;
            this.txtCalleSecundaria.SelectionStart = 0;
            this.txtCalleSecundaria.Size = new System.Drawing.Size(605, 23);
            this.txtCalleSecundaria.TabIndex = 26;
            this.txtCalleSecundaria.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(353, 278);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(111, 19);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Características";
            // 
            // txtOtros
            // 
            this.txtOtros.Depth = 0;
            this.txtOtros.Hint = "";
            this.txtOtros.Location = new System.Drawing.Point(177, 439);
            this.txtOtros.Margin = new System.Windows.Forms.Padding(2);
            this.txtOtros.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.PasswordChar = '\0';
            this.txtOtros.SelectedText = "";
            this.txtOtros.SelectionLength = 0;
            this.txtOtros.SelectionStart = 0;
            this.txtOtros.Size = new System.Drawing.Size(587, 23);
            this.txtOtros.TabIndex = 38;
            this.txtOtros.UseSystemPasswordChar = false;
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Depth = 0;
            this.lblOtros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOtros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOtros.Location = new System.Drawing.Point(117, 439);
            this.lblOtros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(50, 19);
            this.lblOtros.TabIndex = 43;
            this.lblOtros.Text = "Otros:";
            // 
            // txtServicios
            // 
            this.txtServicios.Depth = 0;
            this.txtServicios.Hint = "";
            this.txtServicios.Location = new System.Drawing.Point(503, 406);
            this.txtServicios.Margin = new System.Windows.Forms.Padding(2);
            this.txtServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.PasswordChar = '\0';
            this.txtServicios.SelectedText = "";
            this.txtServicios.SelectionLength = 0;
            this.txtServicios.SelectionStart = 0;
            this.txtServicios.Size = new System.Drawing.Size(261, 23);
            this.txtServicios.TabIndex = 37;
            this.txtServicios.UseSystemPasswordChar = false;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Depth = 0;
            this.lblServicios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblServicios.Location = new System.Drawing.Point(416, 410);
            this.lblServicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(75, 19);
            this.lblServicios.TabIndex = 42;
            this.lblServicios.Text = "Servicios:";
            // 
            // txtParqueaderos
            // 
            this.txtParqueaderos.Depth = 0;
            this.txtParqueaderos.Hint = "";
            this.txtParqueaderos.Location = new System.Drawing.Point(179, 406);
            this.txtParqueaderos.Margin = new System.Windows.Forms.Padding(2);
            this.txtParqueaderos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtParqueaderos.Name = "txtParqueaderos";
            this.txtParqueaderos.PasswordChar = '\0';
            this.txtParqueaderos.SelectedText = "";
            this.txtParqueaderos.SelectionLength = 0;
            this.txtParqueaderos.SelectionStart = 0;
            this.txtParqueaderos.Size = new System.Drawing.Size(215, 23);
            this.txtParqueaderos.TabIndex = 35;
            this.txtParqueaderos.UseSystemPasswordChar = false;
            // 
            // lblParqueaderos
            // 
            this.lblParqueaderos.AutoSize = true;
            this.lblParqueaderos.Depth = 0;
            this.lblParqueaderos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblParqueaderos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParqueaderos.Location = new System.Drawing.Point(32, 410);
            this.lblParqueaderos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParqueaderos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblParqueaderos.Name = "lblParqueaderos";
            this.lblParqueaderos.Size = new System.Drawing.Size(135, 19);
            this.lblParqueaderos.TabIndex = 41;
            this.lblParqueaderos.Text = "Nro Parqueaderos:";
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Depth = 0;
            this.txtHabitaciones.Hint = "";
            this.txtHabitaciones.Location = new System.Drawing.Point(551, 374);
            this.txtHabitaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.PasswordChar = '\0';
            this.txtHabitaciones.SelectedText = "";
            this.txtHabitaciones.SelectionLength = 0;
            this.txtHabitaciones.SelectionStart = 0;
            this.txtHabitaciones.Size = new System.Drawing.Size(213, 23);
            this.txtHabitaciones.TabIndex = 33;
            this.txtHabitaciones.UseSystemPasswordChar = false;
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Depth = 0;
            this.lblHabitaciones.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHabitaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHabitaciones.Location = new System.Drawing.Point(416, 378);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(131, 19);
            this.lblHabitaciones.TabIndex = 40;
            this.lblHabitaciones.Text = "Nro Habitaciones:";
            // 
            // txtNroBanios
            // 
            this.txtNroBanios.Depth = 0;
            this.txtNroBanios.Hint = "";
            this.txtNroBanios.Location = new System.Drawing.Point(515, 342);
            this.txtNroBanios.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroBanios.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroBanios.Name = "txtNroBanios";
            this.txtNroBanios.PasswordChar = '\0';
            this.txtNroBanios.SelectedText = "";
            this.txtNroBanios.SelectionLength = 0;
            this.txtNroBanios.SelectionStart = 0;
            this.txtNroBanios.Size = new System.Drawing.Size(249, 23);
            this.txtNroBanios.TabIndex = 32;
            this.txtNroBanios.UseSystemPasswordChar = false;
            // 
            // lblNroBanios
            // 
            this.lblNroBanios.AutoSize = true;
            this.lblNroBanios.Depth = 0;
            this.lblNroBanios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroBanios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroBanios.Location = new System.Drawing.Point(416, 346);
            this.lblNroBanios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroBanios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroBanios.Name = "lblNroBanios";
            this.lblNroBanios.Size = new System.Drawing.Size(84, 19);
            this.lblNroBanios.TabIndex = 39;
            this.lblNroBanios.Text = "Nro Baños:";
            // 
            // txtNroPlantas
            // 
            this.txtNroPlantas.Depth = 0;
            this.txtNroPlantas.Hint = "";
            this.txtNroPlantas.Location = new System.Drawing.Point(179, 374);
            this.txtNroPlantas.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroPlantas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroPlantas.Name = "txtNroPlantas";
            this.txtNroPlantas.PasswordChar = '\0';
            this.txtNroPlantas.SelectedText = "";
            this.txtNroPlantas.SelectionLength = 0;
            this.txtNroPlantas.SelectionStart = 0;
            this.txtNroPlantas.Size = new System.Drawing.Size(215, 23);
            this.txtNroPlantas.TabIndex = 31;
            this.txtNroPlantas.UseSystemPasswordChar = false;
            // 
            // txtMetros
            // 
            this.txtMetros.Depth = 0;
            this.txtMetros.Hint = "";
            this.txtMetros.Location = new System.Drawing.Point(177, 342);
            this.txtMetros.Margin = new System.Windows.Forms.Padding(2);
            this.txtMetros.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.PasswordChar = '\0';
            this.txtMetros.SelectedText = "";
            this.txtMetros.SelectionLength = 0;
            this.txtMetros.SelectionStart = 0;
            this.txtMetros.Size = new System.Drawing.Size(217, 23);
            this.txtMetros.TabIndex = 30;
            this.txtMetros.UseSystemPasswordChar = false;
            // 
            // lblNroPlantas
            // 
            this.lblNroPlantas.AutoSize = true;
            this.lblNroPlantas.Depth = 0;
            this.lblNroPlantas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroPlantas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroPlantas.Location = new System.Drawing.Point(75, 374);
            this.lblNroPlantas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroPlantas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroPlantas.Name = "lblNroPlantas";
            this.lblNroPlantas.Size = new System.Drawing.Size(92, 19);
            this.lblNroPlantas.TabIndex = 36;
            this.lblNroPlantas.Text = "Nro Plantas:";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Depth = 0;
            this.lblMetros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMetros.Location = new System.Drawing.Point(32, 346);
            this.lblMetros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMetros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(135, 19);
            this.lblMetros.TabIndex = 34;
            this.lblMetros.Text = "Metros cuadrados:";
            // 
            // lblFotoPrincipal
            // 
            this.lblFotoPrincipal.AutoSize = true;
            this.lblFotoPrincipal.Depth = 0;
            this.lblFotoPrincipal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFotoPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFotoPrincipal.Location = new System.Drawing.Point(33, 241);
            this.lblFotoPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFotoPrincipal.Name = "lblFotoPrincipal";
            this.lblFotoPrincipal.Size = new System.Drawing.Size(106, 19);
            this.lblFotoPrincipal.TabIndex = 44;
            this.lblFotoPrincipal.Text = "Foto Principal:";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCargarImagen.Location = new System.Drawing.Point(146, 237);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(162, 29);
            this.btnCargarImagen.TabIndex = 45;
            this.btnCargarImagen.Text = "Cargar Imágen";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(435, 212);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(113, 19);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "Fecha Registro:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // FrmPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 695);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.lblFotoPrincipal);
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
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtCalleSecundaria);
            this.Controls.Add(this.lblCalleSecundaria);
            this.Controls.Add(this.txtCallePrincipal);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtIdPropiedad);
            this.Controls.Add(this.cbxEstadoPropiedad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.cboParroquia);
            this.Controls.Add(this.cboCanton);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblParroquia);
            this.Controls.Add(this.lblCanton);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.cboTipoPropiedad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarPropiedad);
            this.Controls.Add(this.dgvPropiedad);
            this.Controls.Add(this.lblEstadoPropiedad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblTipoPropiedad);
            this.Controls.Add(this.lblIdPropiedad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPropiedad";
            this.Text = "Propiedad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblIdPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblTipoPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblProvincia;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialLabel lblEstadoPropiedad;
        private System.Windows.Forms.DataGridView dgvPropiedad;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarPropiedad;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.ComboBox cboTipoPropiedad;
        private System.Windows.Forms.ComboBox cboProvincia;
        private MaterialSkin.Controls.MaterialLabel lblCanton;
        private MaterialSkin.Controls.MaterialLabel lblParroquia;
        private MaterialSkin.Controls.MaterialLabel lblBarrio;
        private System.Windows.Forms.ComboBox cboCanton;
        private System.Windows.Forms.ComboBox cboParroquia;
        private System.Windows.Forms.ComboBox cboBarrio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private MaterialSkin.Controls.MaterialCheckBox cbxEstadoPropiedad;
        private MaterialSkin.Controls.MaterialLabel txtIdPropiedad;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCallePrincipal;
        private MaterialSkin.Controls.MaterialLabel lblCalleSecundaria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalleSecundaria;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOtros;
        private MaterialSkin.Controls.MaterialLabel lblOtros;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServicios;
        private MaterialSkin.Controls.MaterialLabel lblServicios;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtParqueaderos;
        private MaterialSkin.Controls.MaterialLabel lblParqueaderos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHabitaciones;
        private MaterialSkin.Controls.MaterialLabel lblHabitaciones;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroBanios;
        private MaterialSkin.Controls.MaterialLabel lblNroBanios;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroPlantas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMetros;
        private MaterialSkin.Controls.MaterialLabel lblNroPlantas;
        private MaterialSkin.Controls.MaterialLabel lblMetros;
        private MaterialSkin.Controls.MaterialLabel lblFotoPrincipal;
        private System.Windows.Forms.Button btnCargarImagen;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}