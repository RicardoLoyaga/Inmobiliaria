namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmCanton
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
            this.components = new System.ComponentModel.Container();
            this.lblProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.lblParroquia = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoCantón = new MaterialSkin.Controls.MaterialLabel();
            this.dgvCanton = new System.Windows.Forms.DataGridView();
            this.btnGuardarCantón = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelarCantón = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbxEstadoCanton = new System.Windows.Forms.CheckBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCanton = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCanton = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iNMOBILIARIADataSet = new Inmobiliaria.IU.Windows.INMOBILIARIADataSet();
            this.iNMOBILIARIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNMOBILIARIADataSet1 = new Inmobiliaria.IU.Windows.INMOBILIARIADataSet1();
            this.cANTONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cANTONTableAdapter = new Inmobiliaria.IU.Windows.INMOBILIARIADataSet1TableAdapters.CANTONTableAdapter();
            this.iDCANTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCANTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECANTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOCANTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMOBILIARIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMOBILIARIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMOBILIARIADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANTONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvincia
            // 
            this.lblProvincia.Depth = 0;
            this.lblProvincia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProvincia.Location = new System.Drawing.Point(265, 75);
            this.lblProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(95, 19);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblParroquia
            // 
            this.lblParroquia.Depth = 0;
            this.lblParroquia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblParroquia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParroquia.Location = new System.Drawing.Point(8, 116);
            this.lblParroquia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblParroquia.Name = "lblParroquia";
            this.lblParroquia.Size = new System.Drawing.Size(95, 19);
            this.lblParroquia.TabIndex = 2;
            this.lblParroquia.Text = "Cantón:";
            // 
            // lblEstadoCantón
            // 
            this.lblEstadoCantón.Depth = 0;
            this.lblEstadoCantón.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoCantón.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoCantón.Location = new System.Drawing.Point(528, 116);
            this.lblEstadoCantón.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoCantón.Name = "lblEstadoCantón";
            this.lblEstadoCantón.Size = new System.Drawing.Size(64, 19);
            this.lblEstadoCantón.TabIndex = 4;
            this.lblEstadoCantón.Text = "Estado:";
            // 
            // dgvCanton
            // 
            this.dgvCanton.AllowUserToAddRows = false;
            this.dgvCanton.AutoGenerateColumns = false;
            this.dgvCanton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCANTONDataGridViewTextBoxColumn,
            this.cODCANTONDataGridViewTextBoxColumn,
            this.nOMBRECANTONDataGridViewTextBoxColumn,
            this.eSTADOCANTONDataGridViewTextBoxColumn});
            this.dgvCanton.DataSource = this.cANTONBindingSource;
            this.dgvCanton.Location = new System.Drawing.Point(12, 143);
            this.dgvCanton.Name = "dgvCanton";
            this.dgvCanton.Size = new System.Drawing.Size(776, 153);
            this.dgvCanton.TabIndex = 8;
            // 
            // btnGuardarCantón
            // 
            this.btnGuardarCantón.Depth = 0;
            this.btnGuardarCantón.Location = new System.Drawing.Point(315, 302);
            this.btnGuardarCantón.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCantón.Name = "btnGuardarCantón";
            this.btnGuardarCantón.Primary = true;
            this.btnGuardarCantón.Size = new System.Drawing.Size(82, 36);
            this.btnGuardarCantón.TabIndex = 20;
            this.btnGuardarCantón.Text = "Guardar";
            this.btnGuardarCantón.UseVisualStyleBackColor = true;
            this.btnGuardarCantón.Click += new System.EventHandler(this.btnGuardarCantón_Click);
            // 
            // btnCancelarCantón
            // 
            this.btnCancelarCantón.Depth = 0;
            this.btnCancelarCantón.Location = new System.Drawing.Point(434, 302);
            this.btnCancelarCantón.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarCantón.Name = "btnCancelarCantón";
            this.btnCancelarCantón.Primary = true;
            this.btnCancelarCantón.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarCantón.TabIndex = 21;
            this.btnCancelarCantón.Text = "Cancelar";
            this.btnCancelarCantón.UseVisualStyleBackColor = true;
            this.btnCancelarCantón.Click += new System.EventHandler(this.btnCancelarCantón_Click);
            // 
            // cbxEstadoCanton
            // 
            this.cbxEstadoCanton.AutoSize = true;
            this.cbxEstadoCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoCanton.Location = new System.Drawing.Point(610, 117);
            this.cbxEstadoCanton.Name = "cbxEstadoCanton";
            this.cbxEstadoCanton.Size = new System.Drawing.Size(65, 21);
            this.cbxEstadoCanton.TabIndex = 22;
            this.cbxEstadoCanton.Text = "Activo";
            this.cbxEstadoCanton.UseVisualStyleBackColor = true;
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(366, 76);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(422, 21);
            this.cboProvincia.TabIndex = 23;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Id Cantón:";
            // 
            // txtIdCanton
            // 
            this.txtIdCanton.Depth = 0;
            this.txtIdCanton.Hint = "";
            this.txtIdCanton.Location = new System.Drawing.Point(113, 75);
            this.txtIdCanton.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCanton.Name = "txtIdCanton";
            this.txtIdCanton.PasswordChar = '\0';
            this.txtIdCanton.SelectedText = "";
            this.txtIdCanton.SelectionLength = 0;
            this.txtIdCanton.SelectionStart = 0;
            this.txtIdCanton.Size = new System.Drawing.Size(135, 23);
            this.txtIdCanton.TabIndex = 27;
            this.txtIdCanton.UseSystemPasswordChar = false;
            // 
            // txtCanton
            // 
            this.txtCanton.Depth = 0;
            this.txtCanton.Hint = "";
            this.txtCanton.Location = new System.Drawing.Point(121, 114);
            this.txtCanton.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.PasswordChar = '\0';
            this.txtCanton.SelectedText = "";
            this.txtCanton.SelectionLength = 0;
            this.txtCanton.SelectionStart = 0;
            this.txtCanton.Size = new System.Drawing.Size(385, 23);
            this.txtCanton.TabIndex = 28;
            this.txtCanton.UseSystemPasswordChar = false;
            // 
            // iNMOBILIARIADataSet
            // 
            this.iNMOBILIARIADataSet.DataSetName = "INMOBILIARIADataSet";
            this.iNMOBILIARIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNMOBILIARIADataSetBindingSource
            // 
            this.iNMOBILIARIADataSetBindingSource.DataSource = this.iNMOBILIARIADataSet;
            this.iNMOBILIARIADataSetBindingSource.Position = 0;
            // 
            // iNMOBILIARIADataSet1
            // 
            this.iNMOBILIARIADataSet1.DataSetName = "INMOBILIARIADataSet1";
            this.iNMOBILIARIADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cANTONBindingSource
            // 
            this.cANTONBindingSource.DataMember = "CANTON";
            this.cANTONBindingSource.DataSource = this.iNMOBILIARIADataSet1;
            // 
            // cANTONTableAdapter
            // 
            this.cANTONTableAdapter.ClearBeforeFill = true;
            // 
            // iDCANTONDataGridViewTextBoxColumn
            // 
            this.iDCANTONDataGridViewTextBoxColumn.DataPropertyName = "IDCANTON";
            this.iDCANTONDataGridViewTextBoxColumn.HeaderText = "IDCANTON";
            this.iDCANTONDataGridViewTextBoxColumn.Name = "iDCANTONDataGridViewTextBoxColumn";
            this.iDCANTONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODCANTONDataGridViewTextBoxColumn
            // 
            this.cODCANTONDataGridViewTextBoxColumn.DataPropertyName = "CODCANTON";
            this.cODCANTONDataGridViewTextBoxColumn.HeaderText = "CODCANTON";
            this.cODCANTONDataGridViewTextBoxColumn.Name = "cODCANTONDataGridViewTextBoxColumn";
            // 
            // nOMBRECANTONDataGridViewTextBoxColumn
            // 
            this.nOMBRECANTONDataGridViewTextBoxColumn.DataPropertyName = "NOMBRECANTON";
            this.nOMBRECANTONDataGridViewTextBoxColumn.HeaderText = "NOMBRECANTON";
            this.nOMBRECANTONDataGridViewTextBoxColumn.Name = "nOMBRECANTONDataGridViewTextBoxColumn";
            // 
            // eSTADOCANTONDataGridViewTextBoxColumn
            // 
            this.eSTADOCANTONDataGridViewTextBoxColumn.DataPropertyName = "ESTADOCANTON";
            this.eSTADOCANTONDataGridViewTextBoxColumn.HeaderText = "ESTADOCANTON";
            this.eSTADOCANTONDataGridViewTextBoxColumn.Name = "eSTADOCANTONDataGridViewTextBoxColumn";
            // 
            // FrmCanton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.txtCanton);
            this.Controls.Add(this.txtIdCanton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.cbxEstadoCanton);
            this.Controls.Add(this.btnCancelarCantón);
            this.Controls.Add(this.btnGuardarCantón);
            this.Controls.Add(this.dgvCanton);
            this.Controls.Add(this.lblEstadoCantón);
            this.Controls.Add(this.lblParroquia);
            this.Controls.Add(this.lblProvincia);
            this.Name = "FrmCanton";
            this.Text = "Información Cantón";
            this.Load += new System.EventHandler(this.FrmCanton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMOBILIARIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMOBILIARIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNMOBILIARIADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANTONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblProvincia;
        private MaterialSkin.Controls.MaterialLabel lblParroquia;
        private MaterialSkin.Controls.MaterialLabel lblEstadoCantón;
        private System.Windows.Forms.DataGridView dgvCanton;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarCantón;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelarCantón;
        private System.Windows.Forms.CheckBox cbxEstadoCanton;
        private System.Windows.Forms.ComboBox cboProvincia;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCanton;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCanton;
        private INMOBILIARIADataSet iNMOBILIARIADataSet;
        private System.Windows.Forms.BindingSource iNMOBILIARIADataSetBindingSource;
        private INMOBILIARIADataSet1 iNMOBILIARIADataSet1;
        private System.Windows.Forms.BindingSource cANTONBindingSource;
        private INMOBILIARIADataSet1TableAdapters.CANTONTableAdapter cANTONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCANTONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCANTONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECANTONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOCANTONDataGridViewTextBoxColumn;
    }
}