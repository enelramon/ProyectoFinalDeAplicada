namespace ProyectoFinal.MasVentas
{
    partial class MasVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasVenta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despacharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.despacharToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.crearClienteToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Add_New_32;
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // crearClienteToolStripMenuItem
            // 
            this.crearClienteToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Customer_16;
            this.crearClienteToolStripMenuItem.Name = "crearClienteToolStripMenuItem";
            this.crearClienteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.crearClienteToolStripMenuItem.Text = "Crear Cliente";
            this.crearClienteToolStripMenuItem.Click += new System.EventHandler(this.crearClienteToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarProductoToolStripMenuItem,
            this.editarDepartamentoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Product_16;
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editarProductoToolStripMenuItem.Text = "Editar Producto";
            this.editarProductoToolStripMenuItem.Click += new System.EventHandler(this.editarProductoToolStripMenuItem_Click);
            // 
            // editarDepartamentoToolStripMenuItem
            // 
            this.editarDepartamentoToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Category_16;
            this.editarDepartamentoToolStripMenuItem.Name = "editarDepartamentoToolStripMenuItem";
            this.editarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editarDepartamentoToolStripMenuItem.Text = "Editar Departamento";
            this.editarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.editarDepartamentoToolStripMenuItem_Click);
            // 
            // despacharToolStripMenuItem
            // 
            this.despacharToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem});
            this.despacharToolStripMenuItem.Name = "despacharToolStripMenuItem";
            this.despacharToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.despacharToolStripMenuItem.Text = "Despachar";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Bill_16;
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuarioToolStripMenuItem,
            this.consultaDeClienteToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem,
            this.consultaDeDepartamentoToolStripMenuItem,
            this.consultaDeFacturaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeUsuarioToolStripMenuItem
            // 
            this.consultaDeUsuarioToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Customer_16;
            this.consultaDeUsuarioToolStripMenuItem.Name = "consultaDeUsuarioToolStripMenuItem";
            this.consultaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.consultaDeUsuarioToolStripMenuItem.Text = "Consulta de Usuario";
            this.consultaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUsuarioToolStripMenuItem_Click);
            // 
            // consultaDeClienteToolStripMenuItem
            // 
            this.consultaDeClienteToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Custosmer_32;
            this.consultaDeClienteToolStripMenuItem.Name = "consultaDeClienteToolStripMenuItem";
            this.consultaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.consultaDeClienteToolStripMenuItem.Text = "Consulta de Cliente";
            this.consultaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaDeClienteToolStripMenuItem_Click);
            // 
            // consultaDeProductosToolStripMenuItem
            // 
            this.consultaDeProductosToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Product_16;
            this.consultaDeProductosToolStripMenuItem.Name = "consultaDeProductosToolStripMenuItem";
            this.consultaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.consultaDeProductosToolStripMenuItem.Text = "Consulta de Productos";
            this.consultaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProductosToolStripMenuItem_Click);
            // 
            // consultaDeDepartamentoToolStripMenuItem
            // 
            this.consultaDeDepartamentoToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Category_16;
            this.consultaDeDepartamentoToolStripMenuItem.Name = "consultaDeDepartamentoToolStripMenuItem";
            this.consultaDeDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.consultaDeDepartamentoToolStripMenuItem.Text = "Consulta de Departamento";
            this.consultaDeDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDepartamentoToolStripMenuItem_Click);
            // 
            // consultaDeFacturaToolStripMenuItem
            // 
            this.consultaDeFacturaToolStripMenuItem.Image = global::ProyectoFinal.Properties.Resources.icons8_Bill_16;
            this.consultaDeFacturaToolStripMenuItem.Name = "consultaDeFacturaToolStripMenuItem";
            this.consultaDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.consultaDeFacturaToolStripMenuItem.Text = "Consulta de Factura";
            this.consultaDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.consultaDeFacturaToolStripMenuItem_Click);
            // 
            // MasVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.contact_center_ventas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 449);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasVenta";
            this.Text = "+Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despacharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFacturaToolStripMenuItem;
    }
}