
namespace Inmobiliaria.IU.Windows.Formulario
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menPrincipal = new System.Windows.Forms.MenuStrip();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePropiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoPropiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.característicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicaciónGeográficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parroquiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónPropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menPrincipal
            // 
            this.menPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem,
            this.registroDePropiedadesToolStripMenuItem,
            this.ubicaciónGeográficaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.propietariosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menPrincipal.Name = "menPrincipal";
            this.menPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menPrincipal.TabIndex = 0;
            this.menPrincipal.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.seguridadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seguridadToolStripMenuItem.Image")));
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // registroDePropiedadesToolStripMenuItem
            // 
            this.registroDePropiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoPropiedadToolStripMenuItem,
            this.característicasToolStripMenuItem,
            this.propiedadesToolStripMenuItem});
            this.registroDePropiedadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDePropiedadesToolStripMenuItem.Image")));
            this.registroDePropiedadesToolStripMenuItem.Name = "registroDePropiedadesToolStripMenuItem";
            this.registroDePropiedadesToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.registroDePropiedadesToolStripMenuItem.Text = "Registro de Propiedades";
            // 
            // tipoPropiedadToolStripMenuItem
            // 
            this.tipoPropiedadToolStripMenuItem.Name = "tipoPropiedadToolStripMenuItem";
            this.tipoPropiedadToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.tipoPropiedadToolStripMenuItem.Text = "Tipo Propiedad";
            this.tipoPropiedadToolStripMenuItem.Click += new System.EventHandler(this.tipoPropiedadToolStripMenuItem_Click);
            // 
            // característicasToolStripMenuItem
            // 
            this.característicasToolStripMenuItem.Name = "característicasToolStripMenuItem";
            this.característicasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.característicasToolStripMenuItem.Text = "Características";
            this.característicasToolStripMenuItem.Click += new System.EventHandler(this.característicasToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            this.propiedadesToolStripMenuItem.Click += new System.EventHandler(this.propiedadesToolStripMenuItem_Click);
            // 
            // ubicaciónGeográficaToolStripMenuItem
            // 
            this.ubicaciónGeográficaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provinciaToolStripMenuItem,
            this.cantónToolStripMenuItem,
            this.parroquiaToolStripMenuItem});
            this.ubicaciónGeográficaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ubicaciónGeográficaToolStripMenuItem.Image")));
            this.ubicaciónGeográficaToolStripMenuItem.Name = "ubicaciónGeográficaToolStripMenuItem";
            this.ubicaciónGeográficaToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.ubicaciónGeográficaToolStripMenuItem.Text = "Ubicación Geográfica";
            this.ubicaciónGeográficaToolStripMenuItem.Click += new System.EventHandler(this.ubicaciónGeográficaToolStripMenuItem_Click);
            // 
            // provinciaToolStripMenuItem
            // 
            this.provinciaToolStripMenuItem.Name = "provinciaToolStripMenuItem";
            this.provinciaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.provinciaToolStripMenuItem.Text = "Provincia";
            this.provinciaToolStripMenuItem.Click += new System.EventHandler(this.provinciaToolStripMenuItem_Click);
            // 
            // cantónToolStripMenuItem
            // 
            this.cantónToolStripMenuItem.Name = "cantónToolStripMenuItem";
            this.cantónToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cantónToolStripMenuItem.Text = "Cantón";
            this.cantónToolStripMenuItem.Click += new System.EventHandler(this.cantónToolStripMenuItem_Click);
            // 
            // parroquiaToolStripMenuItem
            // 
            this.parroquiaToolStripMenuItem.Name = "parroquiaToolStripMenuItem";
            this.parroquiaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.parroquiaToolStripMenuItem.Text = "Parroquia";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // administraciónClientesToolStripMenuItem
            // 
            this.administraciónClientesToolStripMenuItem.Name = "administraciónClientesToolStripMenuItem";
            this.administraciónClientesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.administraciónClientesToolStripMenuItem.Text = "Administración Clientes";
            this.administraciónClientesToolStripMenuItem.Click += new System.EventHandler(this.administraciónClientesToolStripMenuItem_Click);
            // 
            // propietariosToolStripMenuItem
            // 
            this.propietariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónPropietariosToolStripMenuItem});
            this.propietariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("propietariosToolStripMenuItem.Image")));
            this.propietariosToolStripMenuItem.Name = "propietariosToolStripMenuItem";
            this.propietariosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.propietariosToolStripMenuItem.Text = "Propietarios";
            // 
            // administraciónPropietariosToolStripMenuItem
            // 
            this.administraciónPropietariosToolStripMenuItem.Name = "administraciónPropietariosToolStripMenuItem";
            this.administraciónPropietariosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.administraciónPropietariosToolStripMenuItem.Text = "Administración propietarios";
            this.administraciónPropietariosToolStripMenuItem.Click += new System.EventHandler(this.administraciónPropietariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propiedadesToolStripMenuItem1});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // propiedadesToolStripMenuItem1
            // 
            this.propiedadesToolStripMenuItem1.Name = "propiedadesToolStripMenuItem1";
            this.propiedadesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.propiedadesToolStripMenuItem1.Text = "Propiedades";
            this.propiedadesToolStripMenuItem1.Click += new System.EventHandler(this.propiedadesToolStripMenuItem1_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menPrincipal;
            this.Name = "FrmMenuPrincipal";
            this.Text = "RB Inmobiliaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menPrincipal.ResumeLayout(false);
            this.menPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menPrincipal;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePropiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoPropiedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem característicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicaciónGeográficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parroquiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónPropietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem1;
    }
}