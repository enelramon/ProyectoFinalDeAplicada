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
        public ReporteFacturas(int id/*List<Factura> bill*/)
        {
            InitializeComponent();
            //datos = bill;
        }

        private void ReporteFacturaViewer_Load(object sender, EventArgs e)
        {
            ReporteFactura abrir = new ReporteFactura();
            abrir.SetDataSource(datos);
           ReporteFacturaViewer.ReportSource = abrir;
           // ReporteFacturaViewer.SelectionFormula = "{View_Facturaciones}.Id=id";
            ReporteFacturaViewer.Refresh();
        }
    }
}
