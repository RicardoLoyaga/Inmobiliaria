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
    public partial class FrmUsuario : MaterialSkin.Controls.MaterialForm
    {

        private UsuarioControlador usuarioControlador;
        private UsuarioVistaModelo usuarioVistaModelo;

        public FrmUsuario()
        {
            InitializeComponent();

            usuarioControlador = new UsuarioControlador();

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
            usuarioVistaModelo = new UsuarioVistaModelo();
            usuarioVistaModelo.NombreUsuario = txtUsuario.Text;
            usuarioVistaModelo.IdentificacionUsuario = txtIdentificacion.Text;
            if (cbxEstadoUsuario.Checked)
            {
                usuarioVistaModelo.Estado = 1;
            }
            else
            {
                usuarioVistaModelo.Estado = 0;
            }

            if (!txtIdUsuario.Text.Equals(""))
            {
                usuarioVistaModelo.IdUsuario = int.Parse(txtIdUsuario.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            dgvUsuario.DataSource = usuarioControlador.GetUsuarioAll();
        }

        private void Insertar()
        {
            if (usuarioControlador.InsertarUsuario(usuarioVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar Usuario!");
            }
        }

        private void Actualizar()
        {
            if (usuarioControlador.ActualizarUsuario(usuarioVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar Usuario!");
            }
        }

        private void actualizarForm()
        {
            txtIdUsuario.Text = "";
            txtUsuario.Text = "";
            txtIdentificacion.Text = "";
            cbxEstadoUsuario.Text = "";
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
    }
}
