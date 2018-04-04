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

namespace ProyectoFinal.Productos
{
    public partial class CProducto : Form
    {
        public CProducto()
        {
            InitializeComponent();
        }
        Expression<Func<Producto, bool>> filtrar = x => true;
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;


            Expression<Func<Producto, bool>> filtrar = x => true;

            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.Idproducto == id;
                    break;
                //Descripcion
                case 1:

                    filtrar = t => t.Descripcion.Contains(CriteriotextBox.Text);
                    break;
                
                //Cantidad
                case 3:

                    filtrar = t => t.Cantidad == Convert.ToInt32(CriteriotextBox.Text);
                    break;
                //precio
                case 4:

                    filtrar = t => t.Precio == Convert.ToInt32(CriteriotextBox.Text);
                    break;
                //idDepartamento
                case 5:

                    filtrar = t => t.DepartamentoId== Convert.ToInt32(CriteriotextBox.Text);
                    break;
            }


            ConsultadataGridView.DataSource = BLL.ProductoBLL.GetList(filtrar);
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {
            ReporteProducto abri = new ReporteProducto(BLL.ProductoBLL.GetList(filtrar));
            abri.Show();
        }
    }
}
