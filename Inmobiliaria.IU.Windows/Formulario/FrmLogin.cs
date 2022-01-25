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
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        private LoginControlador loginControlador;
        private LoginVistaModelo loginVistaModelo;
        public FrmLogin()
        {
            InitializeComponent();

            loginControlador = new LoginControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Yellow700, Accent.Green700, TextShade.WHITE);

            
        }

        private void cboRolLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarLogin_Click(object sender, EventArgs e)
        {
            loginVistaModelo = new LoginVistaModelo();
            if (cboRolLogin.Text.Equals("ADMINISTRADOR"))
            {
                loginVistaModelo.IdRol = 1;
            }
            else { loginVistaModelo.IdRol = 2; };
             
            loginVistaModelo.Usuario = txtUsuarioLogin.Text;
            loginVistaModelo.Contrasena = txtContrasenaLogin.Text;
            loginVistaModelo.Estado = int.Parse(txtEstadoLogin.Text);
            
            if (!txtIdLogin.Text.Equals(""))
            {
                loginVistaModelo.IdLogin = int.Parse(txtIdLogin.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarLogin();
        }

        private void ListarLogin()
        {
            dgvSeguridades.DataSource = loginControlador.GetLoginAll();
        }

        private void Insertar()
        {
            if (loginControlador.InsertarLogin(loginVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar seguridades!");
            }
        }

        private void actualizarForm()
        {
            txtIdLogin.Text = "";
            cboRolLogin.Text = "";
            txtUsuarioLogin.Text = "";
            txtContrasenaLogin.Text = "";
            txtEstadoLogin.Text = "";
        }

        private void Actualizar()
        {
            if (loginControlador.ActualizarLogin(loginVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar seguridades!");
            }
        }

        private void dgvSeguridades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ListarLogin();

            cboRolLogin.DataSource = loginControlador.poblarCboRol();
            cboRolLogin.DisplayMember = "Rol1";
            cboRolLogin.ValueMember = "IDROL";
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
