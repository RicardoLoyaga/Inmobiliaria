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
        public FrmPropiedad()
        {
            InitializeComponent();

            propiedadControlador = new PropiedadControlador();

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
            propiedadVistaModelo.IdPropietario = int.Parse(cboPropietario.Text);
            propiedadVistaModelo.IdCaracteristica = int.Parse(cboCaracteristica.Text);
            propiedadVistaModelo.IdProvincia = int.Parse(cboProvincia.Text);
            propiedadVistaModelo.IdTipoPropiedad = int.Parse(cboTipoPropiedad.Text);
            propiedadVistaModelo.IdUsuario = int.Parse(cboUsuarioPropiedad.Text);
            propiedadVistaModelo.Precio = decimal.Parse(txtPrecio.Text);
            
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
            txtIdPropiedad.Text = "";
            cboCaracteristica.Text = "";
            cboPropietario.Text = "";
            cboProvincia.Text = "";
            cboTipoPropiedad.Text = "";
            cboUsuarioPropiedad.Text = "";
            txtPrecio.Text = "";
            cbxEstadoPropiedad.Text = "";
        }
    }
}
