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
    public partial class FrmRol : MaterialSkin.Controls.MaterialForm
    {
        private RolControlador rolControlador;
        private RolVistaModelo rolVistaModelo;

        public FrmRol()
        {
            InitializeComponent();

            rolControlador = new RolControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Blue900, Primary.Yellow700, Accent.Green700, TextShade.WHITE);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rolVistaModelo = new RolVistaModelo();
            rolVistaModelo.Rol1 = txtRol.Text;
            rolVistaModelo.EstadoRol = int.Parse(txtEstadoRol.Text);
            if (!txtIdRol.Text.Equals(""))
            {
                rolVistaModelo.IdRol = int.Parse(txtIdRol.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarRol();

        }

        private void ListarRol()
        {
            dgvRol.DataSource = rolControlador.GetRolAll();
        }

        private void Insertar()
        {
            if (rolControlador.InsertarRol(rolVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar rol!");
            }
        }

        private void actualizarForm()
        {
            txtIdRol.Text = "";
            txtRol.Text = "";
            txtEstadoRol.Text = "";
        }

        private void Actualizar()
        {
            if (rolControlador.ActualizarRol(rolVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar rol!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            ListarRol();
        }

        private void txtIdRol_Click(object sender, EventArgs e)
        {
            
        }
    }
}
