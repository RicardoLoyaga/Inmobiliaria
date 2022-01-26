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
    public partial class FrmTipoPropiedad : MaterialSkin.Controls.MaterialForm
    {
        private TipoPropiedadControlador tipoPropiedadControlador;
        private TipoPropiedadVistaModelo tipoPropiedadVistaModelo;
        public FrmTipoPropiedad()
        {
            InitializeComponent();

            tipoPropiedadControlador = new TipoPropiedadControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.LightBlue900, Primary.Yellow700, Accent.Red700, TextShade.WHITE);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tipoPropiedadVistaModelo = new TipoPropiedadVistaModelo();
            tipoPropiedadVistaModelo.TipoPropiedad = txtTipoPropiedad.Text;

            if (cbxEstadoTipoPropiedad.Checked)
            {
                tipoPropiedadVistaModelo.EstadoTipoPropiedad = 1;
            }
            else
            {
                tipoPropiedadVistaModelo.EstadoTipoPropiedad = 0;
            }

            if (!txtIdTipoPropiedad.Text.Equals(""))
            {
                tipoPropiedadVistaModelo.IdTipoPropiedad = int.Parse(txtIdTipoPropiedad.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarTipoPropiedad();
        }

        private void ListarTipoPropiedad()
        {
            dgvTipoPropiedad.DataSource = tipoPropiedadControlador.GetTipoPropiedadAll();
        }

        private void Insertar()
        {
            if (tipoPropiedadControlador.InsertarTipoPropiedad(tipoPropiedadVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar Tipo Propiedad!");
            }
        }

        private void actualizarForm()
        {
            txtIdTipoPropiedad.Text = "";
            txtTipoPropiedad.Text = "";
            cbxEstadoTipoPropiedad.Text = "";
        }

        private void Actualizar()
        {
            if (tipoPropiedadControlador.ActualizarTipoPropiedad(tipoPropiedadVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar Tipo Propiedad!");
            }
        }

        private void FrmTipoPropiedad_Load(object sender, EventArgs e)
        {
            ListarTipoPropiedad();
        }
    }
}
