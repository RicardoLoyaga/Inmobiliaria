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

            propiedadVistaModelo = new PropiedadVistaModelo();
            propiedadVistaModelo.IdProvincia = int.Parse(cboProvincia.SelectedValue.ToString());
            propiedadVistaModelo.IdTipoPropiedad = int.Parse(cboTipoPropiedad.SelectedValue.ToString());
            //propiedadVistaModelo.IdCaracteristica= int.Parse(cbo.SelectedValue.ToString());
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
                //resp = true;

            }
            else
            {
                Insertar();
                //resp = true;
            }


            caracteristicaVistaModelo = new CaracteristicaVistaModelo();
            caracteristicaVistaModelo.Plantas = int.Parse(txtNroPlantas.Text);
            caracteristicaVistaModelo.Habitaciones = int.Parse(txtHabitaciones.Text);
            caracteristicaVistaModelo.MetrosCuadrados = int.Parse(txtMetros.Text);
            caracteristicaVistaModelo.Parqueaderos = int.Parse(txtParqueaderos.Text);
            caracteristicaVistaModelo.Servicios = txtServicios.Text;
            caracteristicaVistaModelo.Banios = int.Parse(txtNroBanios.Text);
            caracteristicaVistaModelo.Otros = txtOtros.Text;

            if (!txtIdCaracteristica.Text.Equals(""))
            {
                caracteristicaVistaModelo.IdCaracteristica = int.Parse(txtIdCaracteristica.Text);
                //if (Propiedad())
                //{
                    ActualizarCaracteristica();
                //}
            }
            else
            {
                //if (Propiedad())
                //{
                    InsertarCaracteristica();
                //}
            }

            ListarPropiedad();
        }

        /*public bool Propiedad()
        {
            bool resp = false;

            propiedadVistaModelo = new PropiedadVistaModelo();
            propiedadVistaModelo.IdProvincia = int.Parse(cboProvincia.SelectedValue.ToString());
            propiedadVistaModelo.IdTipoPropiedad = int.Parse(cboTipoPropiedad.SelectedValue.ToString());
            //propiedadVistaModelo.IdCaracteristica= int.Parse(cbo.SelectedValue.ToString());
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
                resp = true;

            }
            else
            {
               Insertar();
                resp = true;
            }
            return resp;
        }*/

        private void InsertarCaracteristica()
        {
            if (caracteristicaControlador.InsertarCaracteristica(caracteristicaVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
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
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar la Caracteristica!");
            }
        }

        private void ListarPropiedad()
        {
            dgvPropiedad.DataSource = propiedadControlador.GetPropiedadAll();
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
            ListarPropiedad();
            cargarProvincia();
            cargarTipoPropiedad();
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
            try
            {
                int idProv = int.Parse(cboProvincia.SelectedValue.ToString());
                cargarCanton(idProv);
            }
            catch (FormatException)
            {
            }
            
        }

        private void cboCanton_SelectedIndexChanged(object sender, EventArgs e)
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
            try
            {
                int idParroquia = int.Parse(cboParroquia.SelectedValue.ToString());
                cargarBarrio(idParroquia);
            }
            catch (FormatException)
            {
            }
        }
    }
}
