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
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Yellow700, Accent.Red700, TextShade.WHITE);
        }

        private void btnGuardarProvincia_Click(object sender, EventArgs e)
        {
            provinciaVistaModelo = new ProvinciaVistaModelo();
            provinciaVistaModelo.NombreProvincia = TxtProvincia.Text;

            if (cbxEstadoProvincia.Checked)
            {
                provinciaVistaModelo.EstadoProvincia = 1;
            }
            else
            {
                provinciaVistaModelo.EstadoProvincia = 0;
            }

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
            TxtIdProvincia.Text = string.Empty;
            TxtProvincia.Text = string.Empty;
            cbxEstadoProvincia.Checked=false;
        }

        private void btnCancelarProvincia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            ListarProvincias();
        }

        private void dgvProvincias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIdProvincia.Text = dgvProvincias.CurrentRow.Cells["idProvincia"].Value.ToString();
            TxtProvincia.Text = dgvProvincias.CurrentRow.Cells["NombreProvincia"].Value.ToString();
        }

        private void btnCancelarProvincia_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
