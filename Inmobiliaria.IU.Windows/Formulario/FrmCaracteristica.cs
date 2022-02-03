using Inmobiliaria.IU.Windows.ControladorAplicacion;
using Inmobiliaria.IU.Windows.VistaModelo;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.IU.Windows.Formulario
{
    public partial class FrmCaracteristica : MaterialSkin.Controls.MaterialForm
    {
        private CaracteristicaControlador caracteristicaControlador;
        private TextBox txtIdCaracteristi;
        private MaterialSkin.Controls.MaterialLabel txtId;
        private MaterialSkin.Controls.MaterialLabel lblIdPropiedad;
        private MaterialSkin.Controls.MaterialLabel lblTipoPropiedad;
        private ComboBox cboTipoPropiedad;
        private GroupBox gboxCompleto;
        private MaterialSkin.Controls.MaterialLabel lblMetros;
        private MaterialSkin.Controls.MaterialLabel lblHabitaciones;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHabitaciones;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroPlantas;
        private MaterialSkin.Controls.MaterialLabel lblParqueaderos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOtros;
        private MaterialSkin.Controls.MaterialLabel lblNroPlantas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtParqueaderos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMetros;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroBanios;
        private MaterialSkin.Controls.MaterialLabel lblOtros;
        private MaterialSkin.Controls.MaterialLabel lblServicios;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServicios;
        private MaterialSkin.Controls.MaterialLabel lblNroBanios;
        private DataGridView dgvCaracteristicas;
        private CaracteristicaVistaModelo caracteristicaVistaModelo;

        public FrmCaracteristica()
        {
            InitializeComponent();

            caracteristicaControlador = new CaracteristicaControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.LightBlue900, Primary.Yellow700, Accent.Red700, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCaracteristicas_Click(object sender, EventArgs e)
        {
            caracteristicaVistaModelo = new CaracteristicaVistaModelo();
            caracteristicaVistaModelo.Plantas = int.Parse(txtNroPlantas.Text);
            caracteristicaVistaModelo.Habitaciones = int.Parse(txtHabitaciones.Text);
            caracteristicaVistaModelo.MetrosCuadrados = int.Parse(txtMetros.Text);
            caracteristicaVistaModelo.Parqueaderos = int.Parse(txtParqueaderos.Text);
            caracteristicaVistaModelo.Servicios = txtServicios.Text;
            caracteristicaVistaModelo.Otros = txtOtros.Text;

            if (!txtIdCaracteristi.Text.Equals(""))
            {
                caracteristicaVistaModelo.IdCaracteristica = int.Parse(txtIdCaracteristi.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarCaracteristica();
        }

        private void ListarCaracteristica()
        {
            dgvCaracteristicas.DataSource = caracteristicaControlador.GetCaracteristicaAll();
        }

        private void Insertar()
        {
            if (caracteristicaControlador.InsertarCaracteristica(caracteristicaVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar característica!");
            }
        }

        private void Actualizar()
        {
            if (caracteristicaControlador.ActualizarCaracteristica(caracteristicaVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar característica!");
            }
        }

        private void actualizarForm()
        {
            txtNroPlantas.Text = "";
            txtHabitaciones.Text = "";
            txtIdCaracteristi.Text = "";
            txtMetros.Text = "";
            txtNroBanios.Text = "";
            txtOtros.Text = "";
            txtParqueaderos.Text = "";
            txtServicios.Text = "";
            
        }

        private void InitializeComponent()
        {
            this.txtIdCaracteristi = new System.Windows.Forms.TextBox();
            this.txtId = new MaterialSkin.Controls.MaterialLabel();
            this.lblIdPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipoPropiedad = new MaterialSkin.Controls.MaterialLabel();
            this.cboTipoPropiedad = new System.Windows.Forms.ComboBox();
            this.gboxCompleto = new System.Windows.Forms.GroupBox();
            this.lblMetros = new MaterialSkin.Controls.MaterialLabel();
            this.lblHabitaciones = new MaterialSkin.Controls.MaterialLabel();
            this.txtHabitaciones = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNroPlantas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblParqueaderos = new MaterialSkin.Controls.MaterialLabel();
            this.txtOtros = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNroPlantas = new MaterialSkin.Controls.MaterialLabel();
            this.txtParqueaderos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMetros = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNroBanios = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblOtros = new MaterialSkin.Controls.MaterialLabel();
            this.lblServicios = new MaterialSkin.Controls.MaterialLabel();
            this.txtServicios = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNroBanios = new MaterialSkin.Controls.MaterialLabel();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridView();
            this.gboxCompleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCaracteristi
            // 
            this.txtIdCaracteristi.Location = new System.Drawing.Point(172, 75);
            this.txtIdCaracteristi.Name = "txtIdCaracteristi";
            this.txtIdCaracteristi.ReadOnly = true;
            this.txtIdCaracteristi.Size = new System.Drawing.Size(100, 20);
            this.txtIdCaracteristi.TabIndex = 51;
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtId.Location = new System.Drawing.Point(153, 76);
            this.txtId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 19);
            this.txtId.TabIndex = 50;
            // 
            // lblIdPropiedad
            // 
            this.lblIdPropiedad.AutoSize = true;
            this.lblIdPropiedad.Depth = 0;
            this.lblIdPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdPropiedad.Location = new System.Drawing.Point(52, 75);
            this.lblIdPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdPropiedad.Name = "lblIdPropiedad";
            this.lblIdPropiedad.Size = new System.Drawing.Size(123, 19);
            this.lblIdPropiedad.TabIndex = 47;
            this.lblIdPropiedad.Text = "Id Caracteristica:";
            // 
            // lblTipoPropiedad
            // 
            this.lblTipoPropiedad.AutoSize = true;
            this.lblTipoPropiedad.Depth = 0;
            this.lblTipoPropiedad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoPropiedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoPropiedad.Location = new System.Drawing.Point(376, 75);
            this.lblTipoPropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPropiedad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoPropiedad.Name = "lblTipoPropiedad";
            this.lblTipoPropiedad.Size = new System.Drawing.Size(114, 19);
            this.lblTipoPropiedad.TabIndex = 48;
            this.lblTipoPropiedad.Text = "Tipo Propiedad:";
            // 
            // cboTipoPropiedad
            // 
            this.cboTipoPropiedad.FormattingEnabled = true;
            this.cboTipoPropiedad.Location = new System.Drawing.Point(490, 74);
            this.cboTipoPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoPropiedad.Name = "cboTipoPropiedad";
            this.cboTipoPropiedad.Size = new System.Drawing.Size(249, 21);
            this.cboTipoPropiedad.TabIndex = 49;
            // 
            // gboxCompleto
            // 
            this.gboxCompleto.Controls.Add(this.lblMetros);
            this.gboxCompleto.Controls.Add(this.lblHabitaciones);
            this.gboxCompleto.Controls.Add(this.txtHabitaciones);
            this.gboxCompleto.Controls.Add(this.txtNroPlantas);
            this.gboxCompleto.Controls.Add(this.lblParqueaderos);
            this.gboxCompleto.Controls.Add(this.txtOtros);
            this.gboxCompleto.Controls.Add(this.lblNroPlantas);
            this.gboxCompleto.Controls.Add(this.txtParqueaderos);
            this.gboxCompleto.Controls.Add(this.txtMetros);
            this.gboxCompleto.Controls.Add(this.txtNroBanios);
            this.gboxCompleto.Controls.Add(this.lblOtros);
            this.gboxCompleto.Controls.Add(this.lblServicios);
            this.gboxCompleto.Controls.Add(this.txtServicios);
            this.gboxCompleto.Controls.Add(this.lblNroBanios);
            this.gboxCompleto.Location = new System.Drawing.Point(12, 110);
            this.gboxCompleto.Name = "gboxCompleto";
            this.gboxCompleto.Size = new System.Drawing.Size(778, 123);
            this.gboxCompleto.TabIndex = 52;
            this.gboxCompleto.TabStop = false;
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Depth = 0;
            this.lblMetros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMetros.Location = new System.Drawing.Point(-4, 16);
            this.lblMetros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMetros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(135, 19);
            this.lblMetros.TabIndex = 34;
            this.lblMetros.Text = "Metros cuadrados:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Depth = 0;
            this.lblHabitaciones.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHabitaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHabitaciones.Location = new System.Drawing.Point(341, 42);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(131, 19);
            this.lblHabitaciones.TabIndex = 40;
            this.lblHabitaciones.Text = "Nro Habitaciones:";
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Depth = 0;
            this.txtHabitaciones.Hint = "";
            this.txtHabitaciones.Location = new System.Drawing.Point(470, 36);
            this.txtHabitaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.PasswordChar = '\0';
            this.txtHabitaciones.SelectedText = "";
            this.txtHabitaciones.SelectionLength = 0;
            this.txtHabitaciones.SelectionStart = 0;
            this.txtHabitaciones.Size = new System.Drawing.Size(80, 23);
            this.txtHabitaciones.TabIndex = 6;
            this.txtHabitaciones.UseSystemPasswordChar = false;
            // 
            // txtNroPlantas
            // 
            this.txtNroPlantas.Depth = 0;
            this.txtNroPlantas.Hint = "";
            this.txtNroPlantas.Location = new System.Drawing.Point(129, 39);
            this.txtNroPlantas.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroPlantas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroPlantas.Name = "txtNroPlantas";
            this.txtNroPlantas.PasswordChar = '\0';
            this.txtNroPlantas.SelectedText = "";
            this.txtNroPlantas.SelectionLength = 0;
            this.txtNroPlantas.SelectionStart = 0;
            this.txtNroPlantas.Size = new System.Drawing.Size(123, 23);
            this.txtNroPlantas.TabIndex = 5;
            this.txtNroPlantas.UseSystemPasswordChar = false;
            // 
            // lblParqueaderos
            // 
            this.lblParqueaderos.AutoSize = true;
            this.lblParqueaderos.Depth = 0;
            this.lblParqueaderos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblParqueaderos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParqueaderos.Location = new System.Drawing.Point(-5, 64);
            this.lblParqueaderos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParqueaderos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblParqueaderos.Name = "lblParqueaderos";
            this.lblParqueaderos.Size = new System.Drawing.Size(135, 19);
            this.lblParqueaderos.TabIndex = 41;
            this.lblParqueaderos.Text = "Nro Parqueaderos:";
            // 
            // txtOtros
            // 
            this.txtOtros.Depth = 0;
            this.txtOtros.Hint = "";
            this.txtOtros.Location = new System.Drawing.Point(129, 88);
            this.txtOtros.Margin = new System.Windows.Forms.Padding(2);
            this.txtOtros.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.PasswordChar = '\0';
            this.txtOtros.SelectedText = "";
            this.txtOtros.SelectionLength = 0;
            this.txtOtros.SelectionStart = 0;
            this.txtOtros.Size = new System.Drawing.Size(287, 23);
            this.txtOtros.TabIndex = 9;
            this.txtOtros.UseSystemPasswordChar = false;
            // 
            // lblNroPlantas
            // 
            this.lblNroPlantas.AutoSize = true;
            this.lblNroPlantas.Depth = 0;
            this.lblNroPlantas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroPlantas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroPlantas.Location = new System.Drawing.Point(38, 39);
            this.lblNroPlantas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroPlantas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroPlantas.Name = "lblNroPlantas";
            this.lblNroPlantas.Size = new System.Drawing.Size(92, 19);
            this.lblNroPlantas.TabIndex = 36;
            this.lblNroPlantas.Text = "Nro Plantas:";
            // 
            // txtParqueaderos
            // 
            this.txtParqueaderos.Depth = 0;
            this.txtParqueaderos.Hint = "";
            this.txtParqueaderos.Location = new System.Drawing.Point(129, 64);
            this.txtParqueaderos.Margin = new System.Windows.Forms.Padding(2);
            this.txtParqueaderos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtParqueaderos.Name = "txtParqueaderos";
            this.txtParqueaderos.PasswordChar = '\0';
            this.txtParqueaderos.SelectedText = "";
            this.txtParqueaderos.SelectionLength = 0;
            this.txtParqueaderos.SelectionStart = 0;
            this.txtParqueaderos.Size = new System.Drawing.Size(123, 23);
            this.txtParqueaderos.TabIndex = 7;
            this.txtParqueaderos.UseSystemPasswordChar = false;
            // 
            // txtMetros
            // 
            this.txtMetros.Depth = 0;
            this.txtMetros.Hint = "";
            this.txtMetros.Location = new System.Drawing.Point(129, 13);
            this.txtMetros.Margin = new System.Windows.Forms.Padding(2);
            this.txtMetros.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.PasswordChar = '\0';
            this.txtMetros.SelectedText = "";
            this.txtMetros.SelectionLength = 0;
            this.txtMetros.SelectionStart = 0;
            this.txtMetros.Size = new System.Drawing.Size(123, 23);
            this.txtMetros.TabIndex = 3;
            this.txtMetros.UseSystemPasswordChar = false;
            // 
            // txtNroBanios
            // 
            this.txtNroBanios.Depth = 0;
            this.txtNroBanios.Hint = "";
            this.txtNroBanios.Location = new System.Drawing.Point(470, 13);
            this.txtNroBanios.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroBanios.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroBanios.Name = "txtNroBanios";
            this.txtNroBanios.PasswordChar = '\0';
            this.txtNroBanios.SelectedText = "";
            this.txtNroBanios.SelectionLength = 0;
            this.txtNroBanios.SelectionStart = 0;
            this.txtNroBanios.Size = new System.Drawing.Size(78, 23);
            this.txtNroBanios.TabIndex = 4;
            this.txtNroBanios.UseSystemPasswordChar = false;
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Depth = 0;
            this.lblOtros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOtros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOtros.Location = new System.Drawing.Point(78, 88);
            this.lblOtros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(50, 19);
            this.lblOtros.TabIndex = 43;
            this.lblOtros.Text = "Otros:";
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Depth = 0;
            this.lblServicios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblServicios.Location = new System.Drawing.Point(395, 64);
            this.lblServicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(75, 19);
            this.lblServicios.TabIndex = 42;
            this.lblServicios.Text = "Servicios:";
            // 
            // txtServicios
            // 
            this.txtServicios.Depth = 0;
            this.txtServicios.Hint = "";
            this.txtServicios.Location = new System.Drawing.Point(470, 61);
            this.txtServicios.Margin = new System.Windows.Forms.Padding(2);
            this.txtServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.PasswordChar = '\0';
            this.txtServicios.SelectedText = "";
            this.txtServicios.SelectionLength = 0;
            this.txtServicios.SelectionStart = 0;
            this.txtServicios.Size = new System.Drawing.Size(261, 23);
            this.txtServicios.TabIndex = 8;
            this.txtServicios.UseSystemPasswordChar = false;
            // 
            // lblNroBanios
            // 
            this.lblNroBanios.AutoSize = true;
            this.lblNroBanios.Depth = 0;
            this.lblNroBanios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroBanios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroBanios.Location = new System.Drawing.Point(386, 16);
            this.lblNroBanios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroBanios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroBanios.Name = "lblNroBanios";
            this.lblNroBanios.Size = new System.Drawing.Size(84, 19);
            this.lblNroBanios.TabIndex = 39;
            this.lblNroBanios.Text = "Nro Baños:";
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicas.Location = new System.Drawing.Point(12, 239);
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            this.dgvCaracteristicas.Size = new System.Drawing.Size(774, 150);
            this.dgvCaracteristicas.TabIndex = 53;
            // 
            // FrmCaracteristica
            // 
            this.ClientSize = new System.Drawing.Size(798, 413);
            this.Controls.Add(this.dgvCaracteristicas);
            this.Controls.Add(this.gboxCompleto);
            this.Controls.Add(this.txtIdCaracteristi);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdPropiedad);
            this.Controls.Add(this.lblTipoPropiedad);
            this.Controls.Add(this.cboTipoPropiedad);
            this.Name = "FrmCaracteristica";
            this.gboxCompleto.ResumeLayout(false);
            this.gboxCompleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
