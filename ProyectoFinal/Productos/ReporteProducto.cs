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

namespace ProyectoFinal.Productos
{
    public partial class ReporteProducto : Form
    {
        List<Producto> datos = new List<Producto>();
        public ReporteProducto(List<Producto> product)
        {
            InitializeComponent();
            datos = product;
        }

        private void ReporteProductoViewer_Load(object sender, EventArgs e)
        {
            ReporteProductos abrir = new ReporteProductos();
            abrir.SetDataSource(datos);
            ReporteProductoViewer.ReportSource = abrir;
            ReporteProductoViewer.Refresh();
        }
    }
}
