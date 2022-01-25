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
    public partial class FrmProvincia : MaterialSkin.Controls.MaterialForm
    {
        private ProvinciaControlador provinciaControlador;
        private ProvinciaVistaModelo provinciaVistaModelo;
        public FrmProvincia()
        {
            InitializeComponent();

            provinciaControlador = new ProvinciaControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Yellow700, Accent.Green700, TextShade.WHITE);
        }

        private void btnGuardarProvincia_Click(object sender, EventArgs e)
        {
            provinciaVistaModelo = new ProvinciaVistaModelo();
            provinciaVistaModelo.Provincia1 = TxtProvincia.Text;
            provinciaVistaModelo.EstadoProvincia = int.Parse(TxtEstado.Text);
            if (!TxtIdProvincia.Text.Equals(""))
            {
                provinciaVistaModelo.IdProvincia = int.Parse(TxtIdProvincia.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarProvincias();
        }

        private void ListarProvincias()
        {
            dgvProvincias.DataSource = provinciaControlador.GetProvinciaAll();
        }

        private void Insertar()
        {
            if (provinciaControlador.InsertarProvincia(provinciaVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar provincia!");
            }
        }

        private void Actualizar()
        {
            if (provinciaControlador.ActualizarProvincia(provinciaVistaModelo))
            {
                MessageBox.Show("Registro se actualizó exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar provincia!");
            }
        }

        private void actualizarForm()
        {
            TxtIdProvincia.Text = "";
            TxtProvincia.Text = "";
            TxtEstado.Text = "";
        }

        private void btnCancelarProvincia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            ListarProvincias();
        }
    }
}
