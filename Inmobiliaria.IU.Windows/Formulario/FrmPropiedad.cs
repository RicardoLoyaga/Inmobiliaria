using System;
using MaterialSkin;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.IU.Windows.ControladorAplicacion;
using Inmobiliaria.IU.Windows.VistaModelo;

namespace Inmobiliaria.IU.Windows.Formulario
{
    public partial class FrmPropiedad : MaterialSkin.Controls.MaterialForm
    {
        private PropiedadControlador propiedadControlador;
        private PropiedadVistaModelo propiedadVistaModelo;
        private CaracteristicaControlador caracteristicaControlador;
        private CaracteristicaVistaModelo caracteristicaVistaModelo;

        private static FrmPropiedad instancia = null;

        public static FrmPropiedad ValidaForm()
        {
            if (instancia == null)
            {
                instancia = new FrmPropiedad();
                return instancia;
            }
            return instancia;
        }
        public FrmPropiedad()
        {
            InitializeComponent();

            propiedadControlador = new PropiedadControlador();
            caracteristicaControlador = new CaracteristicaControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.LightBlue900, Primary.Yellow700, Accent.Red700, TextShade.WHITE);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarPropiedad_Click(object sender, EventArgs e)
        {
            if (cboTipoPropiedad.SelectedValue.ToString() == "1")
            {
                caracteristicaVistaModelo = new CaracteristicaVistaModelo();
                caracteristicaVistaModelo.Plantas = int.Parse(txtNroPlantas.Text);
                caracteristicaVistaModelo.Habitaciones = int.Parse(txtHabitaciones.Text);
                caracteristicaVistaModelo.MetrosCuadrados = float.Parse(txtMetros.Text);
                caracteristicaVistaModelo.Parqueaderos = int.Parse(txtParqueaderos.Text);
                caracteristicaVistaModelo.Servicios = txtServicios.Text;
                caracteristicaVistaModelo.Banios = int.Parse(txtNroBanios.Text);
                caracteristicaVistaModelo.Otros = txtOtros.Text;
            }
            else if (cboTipoPropiedad.SelectedValue.ToString() == "2")
            {
                caracteristicaVistaModelo = new CaracteristicaVistaModelo();
                caracteristicaVistaModelo.MetrosCuadrados = int.Parse(txtMetrosTerreno.Text);
                caracteristicaVistaModelo.Servicios = txtServicioTerreno.Text;
                caracteristicaVistaModelo.Otros = txtOtroTerreno.Text;
            }
            else
            {
                caracteristicaVistaModelo = new CaracteristicaVistaModelo();
                caracteristicaVistaModelo.MetrosCuadrados = float.Parse(txtMetrosOficina.Text);
                caracteristicaVistaModelo.Servicios = txtServiciosOficina.Text;
                caracteristicaVistaModelo.Banios = int.Parse(txtBaniosOficina.Text);
                caracteristicaVistaModelo.Habitaciones = int.Parse(txtNroHabitacionesOficina.Text);
                caracteristicaVistaModelo.Parqueaderos = int.Parse(txtNroParqueaderoOficina.Text);
                caracteristicaVistaModelo.Otros = txtOtrosOficina.Text;
            }
            

            if (!txtIdCaracteristica.Text.Equals(""))
            {
                caracteristicaVistaModelo.IdCaracteristica = int.Parse(txtIdCaracteristica.Text);
                ActualizarCaracteristica();
            }
            else
            {
                InsertarCaracteristica();
            }

            propiedadVistaModelo = new PropiedadVistaModelo();
            //caracteristicaVistaModelo = new CaracteristicaVistaModelo();
            propiedadVistaModelo.IdProvincia = cboProvincia.SelectedIndex + 1;
            propiedadVistaModelo.IdTipoPropiedad = cboTipoPropiedad.SelectedIndex+1;
            //propiedadVistaModelo.IdCaracteristica= int.Parse(txtIdCaracteristi.Text);
            //propiedadVistaModelo.IdPropietario = int.Parse()
            propiedadVistaModelo.Precio = decimal.Parse(txtPrecio.Text);
            propiedadVistaModelo.CallePrincipal = txtCallePrincipal.Text;
            propiedadVistaModelo.CalleSecundaria = txtCalleSecundaria.Text;
            propiedadVistaModelo.FechaRegistroPropiedad = dtpFechaRegistro.Value;
            propiedadVistaModelo.FotoPrincipal = picFoto.ImageLocation;

            if (cbxEstadoPropiedad.Checked)
            {
                propiedadVistaModelo.EstadoPropiedad = 1;
            }
            else
            {
                propiedadVistaModelo.EstadoPropiedad = 0;
            }

            if (!txtIdPropiedad.Text.Equals(""))
            {
                propiedadVistaModelo.IdPropiedad = int.Parse(txtIdPropiedad.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }

            ListarPropiedad();

        }

        private void InsertarCaracteristica()
        {
            if (caracteristicaControlador.InsertarCaracteristica(caracteristicaVistaModelo))
            {
                MessageBox.Show("Característica guardada exitosamente!!");
                //actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar la Caracteristica!");
            }
        }

        private void ActualizarCaracteristica()
        {
            if (caracteristicaControlador.ActualizarCaracteristica(caracteristicaVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                //actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar la Caracteristica!");
            }
        }

        private void ListarPropiedad()
        {
            dgvPropiedadCaracteristica.DataSource = propiedadControlador.GetPropiedadAll();
        }

        private void Insertar()
        {
            if (propiedadControlador.InsertarPropiedad(propiedadVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar la Propiedad!");
            }
        }

        private void Actualizar()
        {
            if (propiedadControlador.ActualizarPropiedad(propiedadVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar la Propiedad!");
            }
        }

        private void actualizarForm()
        {
            cboProvincia.ValueMember = string.Empty;
            cboCanton.ValueMember = string.Empty;
            cboParroquia.ValueMember = string.Empty;
            cboBarrio.ValueMember = string.Empty;
            txtCallePrincipal.Text = string.Empty;
            txtCalleSecundaria.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            dtpFechaRegistro.Value = DateTime.Today;
            picFoto.Image = null;
        }

        private void FrmPropiedad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNMOBILIARIADataSet.PROPIEDAD' Puede moverla o quitarla según sea necesario.
            this.pROPIEDADTableAdapter.Fill(this.iNMOBILIARIADataSet.PROPIEDAD);
            ListarPropiedad();
            cargarProvincia();
            cargarTipoPropiedad();
            //gboxCompleto.Hide();
            gbxOficina.Hide();
            gbxTerreno.Hide();
        }

        public void cargarProvincia()
        {
            cboProvincia.DataSource = propiedadControlador.poblarCboProvincia();
            cboProvincia.DisplayMember = "NombreProvincia";
            cboProvincia.ValueMember = "IdProvincia";
        }

        public void cargarCanton(int id)
        {
            //cboCanton.DataSource = propiedadControlador.poblarCboCanton(int.Parse(cboProvincia.SelectedValue.ToString()));
            cboCanton.DataSource = propiedadControlador.poblarCboCanton(id);
            cboCanton.DisplayMember = "NombreCanton";
            cboCanton.ValueMember = "IdCanton";
        }

        public void cargarParroquia(int idCa)
        {
            //cboCanton.DataSource = propiedadControlador.poblarCboCanton(int.Parse(cboProvincia.SelectedValue.ToString()));
            cboParroquia.DataSource = propiedadControlador.poblarCboParroquia(idCa);
            cboParroquia.DisplayMember = "NombreParroquia";
            cboParroquia.ValueMember = "IdParroquia";
        }

        public void cargarBarrio(int idPar)
        {
            //cboCanton.DataSource = propiedadControlador.poblarCboCanton(int.Parse(cboProvincia.SelectedValue.ToString()));
            cboBarrio.DataSource = propiedadControlador.poblarCboBarrio(idPar);
            cboBarrio.DisplayMember = "Barrio1";
            cboBarrio.ValueMember = "IdBarrio";
        }

        public void cargarTipoPropiedad()
        {
            cboTipoPropiedad.DataSource = propiedadControlador.poblarCboTipoPropiedad();
            cboTipoPropiedad.DisplayMember = "NombreTipoPropiedad";
            cboTipoPropiedad.ValueMember = "IdTipoPropiedad";
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            ofdFoto.FileName = string.Empty;
            if (ofdFoto.ShowDialog()==DialogResult.OK)
            {
                picFoto.Load(ofdFoto.FileName);
            }
            ofdFoto.FileName = string.Empty;
        }

        private void cboParroquia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboProvincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int idProv = int.Parse(cboProvincia.SelectedValue.ToString());
                cargarCanton(idProv);
            }
            catch (FormatException)
            {
            }
        }

        private void cboCanton_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int idCanton = int.Parse(cboCanton.SelectedValue.ToString());
                cargarParroquia(idCanton);
            }
            catch (FormatException)
            {
            }
        }

        private void cboParroquia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int idParroquia = int.Parse(cboParroquia.SelectedValue.ToString());
                cargarBarrio(idParroquia);
            }
            catch (FormatException)
            {
            }
        }

        private void cboBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoPropiedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idTipoPropiedad = int.Parse(cboTipoPropiedad.SelectedValue.ToString());
                switch (idTipoPropiedad)
                {
                    case 1: gboxCompleto.Show();
                        gboxCompleto.BringToFront();
                        gbxTerreno.Hide();
                        gbxOficina.Hide();
                        break;
                    case 2: 
                        gbxTerreno.Show();
                        gbxTerreno.BringToFront();
                        break;
                    case 3: 
                        gbxOficina.Show();
                        gbxOficina.BringToFront();
                        break;
                    case 4:
                        gbxOficina.Show();
                        gbxOficina.BringToFront();
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
