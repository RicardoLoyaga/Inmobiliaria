﻿using Inmobiliaria.Dominio.Modelo.Entidades;
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
    public partial class FrmInciarSesion : MaterialSkin.Controls.MaterialForm
    {
        private LoginControlador loginControlador;
        private LoginVistaModelo loginVistaModelo;
        int intentos = 0;
        public FrmInciarSesion()
        {
            InitializeComponent();

            loginControlador = new LoginControlador();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Blue600, Primary.Yellow700, Accent.Green700, TextShade.WHITE);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            
            if (intentos < 3)
            {
                if (!string.IsNullOrWhiteSpace(txtUsuarioInicioSesion.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txtContrasenaInicioSesion.Text))
                    {
                        try
                        {
                            LOGIN login = loginControlador.username(txtUsuarioInicioSesion.Text);

                            if (login != null)
                            {
                            
                                
                                    if (login.USUARIO == txtUsuarioInicioSesion.Text && intentos<3)
                                    {
                                        if (login.CONTRASENA == txtContrasenaInicioSesion.Text && intentos<3)
                                        {
                                            FrmMenuPrincipal frm = new FrmMenuPrincipal();
                                            frm.Show();
                                        }
                                        else
                                        {
                                            lblContrasenaValidacion.Text = "Contraseña incorrecta";
                                            txtContrasenaInicioSesion.Text = "";
                                            intentos++;
                                        }
                                    }
                                    else
                                    {
                                        lblUsuarioValidacion.Text = "Usuario Incorrecto";
                                        txtUsuarioInicioSesion.Text = "";
                                        intentos++;
                                    }
                            
                            }
                            else
                            {
                                MessageBox.Show("Usuario no existe");
                                limpiar();
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }
                    else
                    {
                        lblContrasenaValidacion.Text = "Contraseña no cumple con seguridad";
                    }
                }
                else
                {
                    lblUsuarioValidacion.Text = "Longitud entre 4 a 15 caracteres";
                }

            }
            else
            {
                MessageBox.Show("Usuario Bloqueado!");
                limpiar();
            }
        }

        public void limpiar()
        {
            txtUsuarioInicioSesion.Text = "";
            txtContrasenaInicioSesion.Text = "";
        }
    }
}
