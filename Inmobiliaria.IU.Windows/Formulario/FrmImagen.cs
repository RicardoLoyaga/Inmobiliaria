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
    public partial class FrmImagen : MaterialSkin.Controls.MaterialForm
    {
        private ImagenControlador imagenControlador;
        private ImagenVistaModelo imagenVistaModelo;
        public FrmImagen()
        {
            InitializeComponent();
            imagenControlador = new ImagenControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Yellow700, Accent.Green700, TextShade.WHITE);
        }

        private void lblmagen_Click(object sender, EventArgs e)
        {

        }
    }
}
