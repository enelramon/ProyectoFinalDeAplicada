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

namespace ProyectoFinal.RDepartamento
{
    public partial class ReporteDepartamento : Form
    {
        List<Departamento> depo = new List<Departamento>();
        public ReporteDepartamento(List<Departamento> dep)
        {
            InitializeComponent();
            depo = dep;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteDepartamentos abrir = new ReporteDepartamentos();
            abrir.SetDataSource(depo);
            DepartamentoViewer.ReportSource = abrir;
            DepartamentoViewer.Refresh();

        }
    }
}
