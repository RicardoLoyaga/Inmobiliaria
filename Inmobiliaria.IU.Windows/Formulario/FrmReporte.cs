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
    public partial class FrmReporte : MaterialSkin.Controls.MaterialForm
    {

        private PropiedadControlador propiedadControlador;
        private PropiedadVistaModelo propiedadVistaModelo;
        public FrmReporte()
        {
            InitializeComponent();

            propiedadControlador = new PropiedadControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Yellow700, Accent.Red700, TextShade.WHITE);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string parametro = txtParametroBusqueda.Text;
            if (parametro is null || parametro == "")
            {
                listarPropeidades();
            }

        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            cargarProvincia();
            cargarTipoPropiedad();
        }

        private void listarPropeidades()
        {
            dgvReportePropiedades.DataSource = propiedadControlador.listadoPropiedades();
        }

        public void cargarProvincia()
        {
            cboProvincia.DataSource = propiedadControlador.poblarCboProvincia();
            cboProvincia.DisplayMember = "NombreProvincia";
            cboProvincia.ValueMember = "IdProvincia";
        }

        public void cargarTipoPropiedad()
        {
            cboTipoPropiedad.DataSource = propiedadControlador.poblarCboTipoPropiedad();
            cboTipoPropiedad.DisplayMember = "NombreTipoPropiedad";
            cboTipoPropiedad.ValueMember = "IdTipoPropiedad";
        }

        private void cboTipoPropiedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idTipoPropiedad = int.Parse(cboTipoPropiedad.SelectedValue.ToString());
            }
            catch (FormatException)
            {
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idProv = int.Parse(cboProvincia.SelectedValue.ToString());
            }
            catch (FormatException)
            {
            }
        }
    }
}
