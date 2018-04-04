using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.RCliente
{
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }
        Expression<Func<Cliente, bool>> filtrar = x => true;
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;


            

            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.IdCliente == id;
                    break;
                //Nombre
                case 1:

                    filtrar = t => t.Nombre.Contains(CriteriotextBox.Text);
                    break;

                //Direccion
                case 3:

                    filtrar = t => t.Direccion == CriteriotextBox.Text;
                    break;
                //Cedula
                case 4:

                    filtrar = t => t.Cedula ==CriteriotextBox.Text;
                    break;
                //Telefono
                case 5:

                    filtrar = t => t.Telefono == CriteriotextBox.Text;
                    break;
            }


            ConsultadataGridView.DataSource = BLL.ClienteBLL.GetList(filtrar);
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {
            ReporteCliente abrir = new ReporteCliente(BLL.ClienteBLL.GetList(filtrar));
            abrir.Show();
        }
    }
}