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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frmRol = new FrmRol();
            frmRol.MdiParent = this;
            frmRol.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void tipoPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoPropiedad frmTipoPropiedad = new FrmTipoPropiedad();
            frmTipoPropiedad.MdiParent = this;
            frmTipoPropiedad.Show();
        }

        private void característicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCaracteristica frmCaracteristica = new FrmCaracteristica();
            frmCaracteristica.MdiParent = this;
            frmCaracteristica.Show();
        }

        private void ubicaciónGeográficaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProvincia frmProvincia = new FrmProvincia();
            frmProvincia.MdiParent = this;
            frmProvincia.Show();
        }

        private void cantónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCanton frmCanton = new FrmCanton();
            frmCanton.MdiParent = this;
            frmCanton.Show();
        }

        private void administraciónClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPropiedad frmPropiedad = new FrmPropiedad();
            frmPropiedad.MdiParent = this;
            frmPropiedad.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administraciónPropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPropietario frmPropietario = new FrmPropietario();
            frmPropietario.MdiParent = this;
            frmPropietario.Show();
        }

        private void propiedadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.MdiParent = this;
            frmReporte.Show();
        }
    }
}
