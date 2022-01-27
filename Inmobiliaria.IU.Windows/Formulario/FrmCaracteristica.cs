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
    public partial class FrmCaracteristica : MaterialSkin.Controls.MaterialForm
    {
        private CaracteristicaControlador caracteristicaControlador;
        private CaracteristicaVistaModelo caracteristicaVistaModelo;

        public FrmCaracteristica()
        {
            InitializeComponent();

            caracteristicaControlador = new CaracteristicaControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.LightBlue900, Primary.Yellow700, Accent.Red700, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCaracteristicas_Click(object sender, EventArgs e)
        {
            caracteristicaVistaModelo = new CaracteristicaVistaModelo();
            caracteristicaVistaModelo.Plantas = int.Parse(txtNroPlantas.Text);
            caracteristicaVistaModelo.Habitaciones = int.Parse(txtHabitaciones.Text);
            caracteristicaVistaModelo.MetrosCuadrados = int.Parse(txtMetros.Text);
            caracteristicaVistaModelo.Parqueaderos = int.Parse(txtParqueaderos.Text);
            caracteristicaVistaModelo.Servicios = txtServicios.Text;
            caracteristicaVistaModelo.Otros = txtOtros.Text;

            if (!txtIdCaracteristica.Text.Equals(""))
            {
                caracteristicaVistaModelo.IdCaracteristica = int.Parse(txtIdCaracteristica.Text);
                Actualizar();
            }
            else
            {
                Insertar();
            }
            ListarCaracteristica();
        }

        private void ListarCaracteristica()
        {
            dgvCaracteristica.DataSource = caracteristicaControlador.GetCaracteristicaAll();
        }

        private void Insertar()
        {
            if (caracteristicaControlador.InsertarCaracteristica(caracteristicaVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al insertar característica!");
            }
        }

        private void Actualizar()
        {
            if (caracteristicaControlador.ActualizarCaracteristica(caracteristicaVistaModelo))
            {
                MessageBox.Show("Registro guardado exitosamente!!");
                actualizarForm();
            }
            else
            {
                MessageBox.Show("!Error al actualizar característica!");
            }
        }

        private void actualizarForm()
        {
            txtNroPlantas.Text = "";
            txtHabitaciones.Text = "";
            txtIdCaracteristica.Text = "";
            txtMetros.Text = "";
            txtNroBanios.Text = "";
            txtOtros.Text = "";
            txtParqueaderos.Text = "";
            txtServicios.Text = "";
            
        }
    }
}
