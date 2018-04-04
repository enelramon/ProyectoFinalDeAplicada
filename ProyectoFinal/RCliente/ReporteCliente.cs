using ProyectoFinal.Entidades;
using ProyectoFinal.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.RCliente
{
    public partial class ReporteCliente : Form
    {
        List<Cliente> datos = new List<Cliente>();
        public ReporteCliente(List<Cliente> customer)
        {
            InitializeComponent();
            datos = customer;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteClientes abrir = new ReporteClientes();
            abrir.SetDataSource(datos);
            ReporteClienteViewer.ReportSource = abrir;
            ReporteClienteViewer.Refresh();
        }
    }
}
