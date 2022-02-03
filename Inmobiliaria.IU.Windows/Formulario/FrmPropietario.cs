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
    public partial class FrmPropietario : MaterialSkin.Controls.MaterialForm
    {
        private PropietarioControlador propietarioControlador;
        private PropietarioVistaModelo propietarioVistaModelo;
        public FrmPropietario()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Yellow700, Accent.Green700, TextShade.WHITE);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            propietarioVistaModelo = new PropietarioVistaModelo();
            propietarioVistaModelo.NombrePropietario = txtNombrePropietario.Text.Trim();
            propietarioVistaModelo.DireccionPropietario = txtDireccionPropietario.Text.Trim();
            propietarioVistaModelo.CelularPropietario = txtCelularPropietario.Text.Trim();
            propietarioVistaModelo.CorreoPropietario = txtCorreoPropietario.Text.Trim();

            if (cbxEstadoPropietario.Checked)
            {
                propietarioVistaModelo.EstadoPropietario = 1;
            }
            else
            {
                propietarioVistaModelo.EstadoPropietario = 0;
            }

            if (!txtIdPropietario.Text.Equals(""))
            {
                propietarioVistaModelo.IdPropietario = int.Parse(txtIdPropietario.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarPropietarios();
        }

        private void ListarPropietarios()
        {
            dgvPropietario.DataSource = propietarioControlador.GetPropietarioAll();
        }

        private void Insertar()
        {
            if (propietarioControlador.InsertarPropietario(propietarioVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar propietario!");
            }
        }
              

          
        private void Actualizar()
        {
            if (propietarioControlador.ActualizarPropietario(propietarioVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar propietario!");
            }
        }

        private void actualizarForm()
        {
            txtIdPropietario.Text = string.Empty;
            txtNombrePropietario.Text = string.Empty;
            txtDireccionPropietario.Text = string.Empty;
            txtCorreoPropietario.Text = string.Empty;
            cbxEstadoPropietario.Checked = false;
        }

        private void FrmPropietario_Load(object sender, EventArgs e)
        {
            ListarPropietarios();

        }
    }
}


