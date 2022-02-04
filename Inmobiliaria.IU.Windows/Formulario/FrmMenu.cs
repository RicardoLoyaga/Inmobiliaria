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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario fusuario = new FrmUsuario();
            fusuario.MdiParent = this;
            fusuario.Show();
            fusuario.BringToFront();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = FrmCliente.ValidaForm();
            frmCliente.MdiParent = this;
            frmCliente.Show();
            frmCliente.BringToFront();
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPropiedad frmPropiedad = FrmPropiedad.ValidaForm();
            frmPropiedad.MdiParent = this;
            frmPropiedad.Show();
            frmPropiedad.BringToFront();
        }

        private void propiedadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.MdiParent = this;
            frmReporte.Show();
        }
    }
}
