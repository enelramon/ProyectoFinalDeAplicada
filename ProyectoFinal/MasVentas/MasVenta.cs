using ProyectoFinal.RDepartamento;
using ProyectoFinal.Productos;
using ProyectoFinal.RLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoFinal.RCliente;
using ProyectoFinal.rFactura;

namespace ProyectoFinal.MasVentas
{
    public partial class MasVenta : Form
    {
        public MasVenta()
        {
            InitializeComponent();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLogIn abrir = new rLogIn();
            abrir.Show();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos abrir = new rProductos();
            abrir.Show();
        }

        private void editarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rDepartamento abrir = new rDepartamento();
            abrir.Show();

        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCliente abrir = new rCliente();
            abrir.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RFactura Abrir = new RFactura();
            Abrir.Show();
        }
    }
}
