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
    public partial class FrmCliente : MaterialSkin.Controls.MaterialForm
    {
        private ClienteControlador clienteControlador;
        private ClienteVistaModelo clienteVistaModelo;

        private static FrmCliente instancia = null;
        public static FrmCliente ValidaForm()
        {
            if (instancia == null)
            {
                instancia = new FrmCliente();
                return instancia;
            }
            return instancia;
        }
        public FrmCliente()
        {
            InitializeComponent();

            clienteControlador = new ClienteControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.LightBlue900, Primary.Yellow700, Accent.Red700, TextShade.WHITE);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
            cboAsesor.DataSource = clienteControlador.poblarCboAsesores();
            cboAsesor.DisplayMember = "NombreUsuario";
            cboAsesor.ValueMember = "IdUsuario";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clienteVistaModelo = new ClienteVistaModelo();
            clienteVistaModelo.NombreCliente = txtNombre.Text;
            clienteVistaModelo.IdentificacionCliente = txtIdentificacion.Text;
            clienteVistaModelo.DireccionCliente = txtDireccion.Text;
            clienteVistaModelo.CorreoCliente = txtEmail.Text;
            clienteVistaModelo.CelularCliente = txtTelefono.Text;
            clienteVistaModelo.Asesor = cboAsesor.SelectedValue.ToString();
            

            if (cbxEstadoCliente.Checked)
            {
                clienteVistaModelo.EstadoCliente = 1;
            }
            else
            {
                clienteVistaModelo.EstadoCliente = 0;
            }

            if (!txtIdCliente.Text.Equals(""))
            {
                clienteVistaModelo.IdCliente = int.Parse(txtIdCliente.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarClientes();
        }

        private void ListarClientes()
        {
            dgvCliente.DataSource = clienteControlador.GetClienteAll();
        }

        private void Insertar()
        {
            if (clienteControlador.InsertarCliente(clienteVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar cliente!");
            }
        }

        private void Actualizar()
        {
            if (clienteControlador.InsertarCliente(clienteVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar cliente!");
            }
        }

        private void actualizarForm()
        {
            txtIdCliente.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cboAsesor.Text = string.Empty;
            cbxEstadoCliente.Checked=false;
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCliente.Text = dgvCliente.CurrentRow.Cells["IdCliente"].Value.ToString();
            txtIdentificacion.Text = dgvCliente.CurrentRow.Cells["IdentificacionCliente"].Value.ToString();
            txtNombre.Text = dgvCliente.CurrentRow.Cells["NombreCliente"].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells["DireccionCliente"].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells["CelularCliente"].Value.ToString();
            txtEmail.Text = dgvCliente.CurrentRow.Cells["CorreoCliente"].Value.ToString();
        }
    }
}
