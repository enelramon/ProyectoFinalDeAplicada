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

namespace ProyectoFinal.RLogin
{
    public partial class ReporteLogIn : Form
    {
        List<Usuario> datos = new List<Usuario>();
        public ReporteLogIn(List<Usuario> log)
        {
            InitializeComponent();
            datos = log;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteUsuario abrir = new ReporteUsuario();
            abrir.SetDataSource(datos);
            ReporteLogInViewer.ReportSource = abrir;
            ReporteLogInViewer.Refresh();
        }
    }
}
