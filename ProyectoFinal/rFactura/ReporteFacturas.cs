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
    public partial class ReporteFacturas : Form
    {
        List<Factura> datos = new List<Factura>();
        public ReporteFacturas(List<Factura> list)
        {
            InitializeComponent();
            datos = list;
        }

        private void ReporteDeFacturaViewer_Load(object sender, EventArgs e)
        {
            FacturaReporte abrir = new FacturaReporte();
            abrir.SetDataSource(datos);
            ReporteDeFacturaViewer.ReportSource = abrir;
            ReporteDeFacturaViewer.Refresh();
        }
    }
}
