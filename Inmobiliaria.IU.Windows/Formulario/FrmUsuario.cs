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
        private UtilControlador utilControlador;

        private static FrmUsuario instancia = null;
        public static FrmUsuario ValidaForm()
        {
            if (instancia==null)
            {
                instancia = new FrmUsuario();
                return instancia;
            }
            return instancia;
        }

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
            usuarioVistaModelo.NombreUsuario = txtUsuario.Text.Trim();
            usuarioVistaModelo.IdentificacionUsuario = txtIdentificacion.Text.Trim();
            usuarioVistaModelo.CorreoUsuario = txtCorreoUsuario.Text.Trim();
            usuarioVistaModelo.Username = txtUsername.Text.Trim();
            usuarioVistaModelo.Contrasena = usuarioControlador.Encriptar(txtContrasena.Text.Trim());
            usuarioVistaModelo.IdRol = int.Parse(cboRolUsuario.SelectedValue.ToString());
            
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
                if (!usuarioControlador.validaUsuario(txtCorreoUsuario.Text.Trim()))
                {
                    Insertar();
                }
                else
                {
                    MessageBox.Show("Usuario ya se encuentra registrado");
                    actualizarForm();
                }
                
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
            txtIdUsuario.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtCorreoUsuario.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            cbxEstadoUsuario.Checked=false;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            cboRolUsuario.DataSource = usuarioControlador.poblarCboRol();
            cboRolUsuario.DisplayMember = "NombreRol";
            cboRolUsuario.ValueMember = "IdRol";
        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuario.Text = dgvUsuario.CurrentRow.Cells["idUsuario"].Value.ToString();
            txtUsuario.Text = dgvUsuario.CurrentRow.Cells["NombreUsuario"].Value.ToString();
            txtIdentificacion.Text = dgvUsuario.CurrentRow.Cells["IdentificacionUsuario"].Value.ToString();
            txtCorreoUsuario.Text = dgvUsuario.CurrentRow.Cells["CorreoUsuario"].Value.ToString();
            txtUsername.Text = dgvUsuario.CurrentRow.Cells["Username"].Value.ToString();
            //cboRolUsuario.ValueMember = dgvUsuario.CurrentRow.Cells["IdRol"].Value.ToString();
        }
    }
}
