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

namespace ProyectoFinal.rFactura
{
    public partial class CFactura : Form
    {
        public CFactura()
        {
            InitializeComponent();
        }
        Expression<Func<Factura, bool>> filtrar = x => true;
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;
            decimal valor = 0;


            

            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.FacturaId == id;
                    break;
                //ClienteID
                case 1:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.ClienteId == id;
                    break;
                //IDusuario
                case 2:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.UsuarioId == id;
                    break;
                //Descripcion
                case 3:

                    filtrar = t => t.Descripcion.Contains(CriteriotextBox.Text);
                    break;
                //fecha
                case 4:
                    filtrar = t => (t.Fecha >= AHoradateTimePicker1.Value) && (t.Fecha <= FInaldateTimePicker2.Value);
                    break;
                //forma de pago
                case 5:

                    filtrar = t => t.FormaDePago.Contains(CriteriotextBox.Text);
                    break;
                //monto
                case 6:

                     valor = Convert.ToDecimal(CriteriotextBox.Text);
                    filtrar = t => t.Monto == valor;
                    break;
                //efectivo recibido
                case 7:

                     valor = Convert.ToDecimal(CriteriotextBox.Text);
                    filtrar = t => t.EfectivoRecibido == valor;
                    break;

                //Devuelta
                case 8:
                     valor = Convert.ToDecimal(CriteriotextBox.Text);
                    filtrar = t => t.Devuelta == valor;
                    break;
            }


            ConsultadataGridView.DataSource = BLL.FacturacionBLL.GetList(filtrar);
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            ReporteFacturas abrir = new ReporteFacturas(Convert.ToInt32(CriteriotextBox.Text));
            abrir.Show();
        }
    }
}
