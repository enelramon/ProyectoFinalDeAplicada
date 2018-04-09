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

namespace ProyectoFinal.rFactura
{
    public partial class ReporteFacturasCliente : Form
    {
        List<Factura> datos = new List<Factura>();
        public ReporteFacturasCliente(List<Factura> bill)
        {
            InitializeComponent();
            datos = bill;
        }

        private void ReporteFacturaViewer_Load(object sender, EventArgs e)
        {
            FacturaReporte abrir = new FacturaReporte();
            abrir.SetDataSource(datos);
             ReporteFacturaViewer.ReportSource = abrir;
            // ReporteFacturaViewer.SelectionFormula = "{View_Facturaciones}.Id=id"; {Facturaciones.ClienteId}=1
            ReporteFacturaViewer.Refresh();
        }
    }
}

