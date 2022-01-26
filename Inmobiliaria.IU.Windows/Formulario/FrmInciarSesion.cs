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
    public partial class FrmInciarSesion : MaterialSkin.Controls.MaterialForm
    {
        public FrmInciarSesion()
        {
            InitializeComponent();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Blue600, Primary.Yellow700, Accent.Green700, TextShade.WHITE);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuarioInicioSesion.Text) && (txtUsuarioInicioSesion.MaxLength>4 && txtUsuarioInicioSesion.MaxLength <= 15))
            {
                if (!string.IsNullOrWhiteSpace(txtContrasenaInicioSesion.Text) && (txtUsuarioInicioSesion.MaxLength > 7 && txtUsuarioInicioSesion.MaxLength <= 15))
                {
                    //var valid = loginControler.ValidaUsuario(LOGIN);

                    if (true)
                    {

                    }
                }
                else
                {
                    lblContrasenaValidacion.Text = "Valor Requerido";
                }
            }
            else
            {
                lblUsuarioValidacion.Text = "Valor Requerido";
            }

            

        }
    }
}
