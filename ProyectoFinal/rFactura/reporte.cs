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
    public partial class reporte : Form
    {
        List<Factura> datos = new List<Factura>();
        public reporte(List<Factura> list)
        {
            datos = list;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Facturass abrir = new Facturass();
            abrir.SetDataSource(datos);
            ReporteDeFacturaViewer.ReportSource = abrir;

            ReporteDeFacturaViewer.Refresh();
        }
    }
}
