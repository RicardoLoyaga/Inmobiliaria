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
    public partial class FrmCanton : MaterialSkin.Controls.MaterialForm
    {
        private CantonControlador cantonControlador;
        private CantonVistaModelo cantonVistaModelo;
        
        public FrmCanton()
        {
            InitializeComponent();

            cantonControlador = new CantonControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Yellow700, Accent.Red700, TextShade.WHITE);
        }

        private void btnGuardarCantón_Click(object sender, EventArgs e)
        {
            cantonVistaModelo = new CantonVistaModelo();
            cantonVistaModelo.NombreCanton = txtCanton.Text;

            if (cbxEstadoCanton.Checked)
            {
                cantonVistaModelo.EstadoCanton = 1;
            }
            else
            {
                cantonVistaModelo.EstadoCanton  = 0;
            }

            if (!txtIdCanton.Text.Equals(""))
            {
                cantonVistaModelo.IdProvincia = int.Parse(txtIdCanton.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarCantones();
        }

        private void ListarCantones()
        {
            dgvCanton.DataSource = cantonControlador.GetCantonAll();
        }

        private void Insertar()
        {
            if (cantonControlador.InsertarCanton(cantonVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar cantón!");
            }
        }

        private void Actualizar()
        {
            if (cantonControlador.ActualizarCanton(cantonVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar cantón!");
            }
        }

        private void actualizarForm()
        {
            txtIdCanton.Text = string.Empty;
            txtCanton.Text = string.Empty;
        }

        private void FrmCanton_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNMOBILIARIADataSet1.CANTON' Puede moverla o quitarla según sea necesario.
            this.cANTONTableAdapter.Fill(this.iNMOBILIARIADataSet1.CANTON);
            ListarCantones();
            cboProvincia.DataSource = cantonControlador.poblarCboProvincia();
            cboProvincia.DisplayMember = "NombreProvincia";
            cboProvincia.ValueMember = "IdProvincia";
        }

        private void btnCancelarCantón_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
