using ProyectoFinal.Entidades;
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
    public partial class RFactura : Form
    {
        decimal Monto = 0;
        Factura billes = new Factura();
        public RFactura()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            FormaDePagocomboBox.Items.Add("Credito");
            FormaDePagocomboBox.Items.Add("Contado");
        }

        private void LimpiarProvider()
        {
            IDerrorProvider.Clear();
            DemaserrorProvider.Clear();
            ProductoerrorProvider.Clear();
        }

        private bool SetError(int error)
        {
            bool paso = false;
            if(error==1&&IDnumericUpDown.Value ==0)
            {
                IDerrorProvider.SetError(IDnumericUpDown, "Llenar Id");
                paso = true;
            }
            if(error == 2 &&UsuarioIdnumericUpDown.Value ==0)
            {
                DemaserrorProvider.SetError(IDnumericUpDown, "Llenar Usuario Id");
                paso = true;
            }
            if (error == 2 && ClienteIdnumericUpDown.Value == 0)
            {
                DemaserrorProvider.SetError(ClienteIdnumericUpDown, "Llenar Cliente Id");
                paso = true;
            }
            if (error == 2 && FormaDePagocomboBox.Text==string.Empty)
            {
                DemaserrorProvider.SetError(FormaDePagocomboBox, "Llenar Forma de pago");
                paso = true;
            }
            if (error == 2 && DescripciponFacturatextBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(DescripciponFacturatextBox, "Llenar descripcion");
                paso = true;
            }
            if (error == 2 && DescripciponFacturatextBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(DescripciponFacturatextBox, "Llenar descripcion");
                paso = true;
            }
            if (error == 2 && EfectivonumericUpDown.Value == 0)
            {
                DemaserrorProvider.SetError(EfectivonumericUpDown, "Llenar Efectivo de caja");
                paso = true;
            }
            if(error ==3&&ProductoIDnumericUpDown.Value==0)
            {
                ProductoerrorProvider.SetError(ProductoIDnumericUpDown, " Llenar id producto");
                paso = true;
            }
            if (error == 4 && DetallenumericUpDown.Value == 0)
            {
                ProductoerrorProvider.SetError(DetallenumericUpDown, " Llenar id producto");
                paso = true;
            }



            return paso;
        }

        private void NUevobutton_Click(object sender, EventArgs e)
        {
            
            IDnumericUpDown.Value = 0;
            UsuarioIdnumericUpDown.Value = 0;
            ClienteIdnumericUpDown.Value = 0;
            FormaDePagocomboBox.Text = string.Empty;
            DescripciponFacturatextBox.Clear();
            ProductoIDnumericUpDown.Value = 0;
            CantidadnumericUpDown.Value = 0;
            DescripcionProductotextBox.Clear();
            PreciotextBox.Clear();
            ImportetextBox.Clear();
            DetallenumericUpDown.Value = 0;
            EfectivonumericUpDown.Value = 0;
            DevueltatextBox.Clear();
            MontotextBox.Clear();
            LimpiarProvider();
            FacturadataGridView.DataSource = null;
            billes.BillDetalle = new List<FacturaDetalle>();
            Monto = 0;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if(SetError(2))
            {
                MessageBox.Show("Llenar Campos vacios");
                return;
            }

            Factura bill = LlenaClase();
            if(IDnumericUpDown.Value==0)
            {
                if(BLL.FacturacionBLL.Guardar(bill))
                {
                    MessageBox.Show("Guardado!!");
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!!");
                }

                BLL.FacturacionBLL.DescontarProductos(billes.BillDetalle, Convert.ToInt32(CantidadnumericUpDown.Value));
               
            }
            else
            {
                if(BLL.FacturacionBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Modificado!!");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar!!");
                }
            }
            
        }

        private Factura LlenaClase()
        {
            Factura bill = new Factura();

            bill.FacturaId = Convert.ToInt32(IDnumericUpDown.Value);
            bill.ClienteId = Convert.ToInt32(ClienteIdnumericUpDown.Value);
            bill.UsuarioId = Convert.ToInt32(UsuarioIdnumericUpDown.Value);
            bill.Fecha = FechadateTimePicker.Value;
            bill.FormaDePago = FormaDePagocomboBox.Text;
            bill.Descripcion = DescripciponFacturatextBox.Text;
            bill.EfectivoRecibido = EfectivonumericUpDown.Value;
            bill.Monto = Convert.ToDecimal(MontotextBox.Text);
            bill.Devuelta = Convert.ToDecimal(DevueltatextBox.Text);
            bill.BillDetalle = billes.BillDetalle;

            return bill;


        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            LimpiarProvider();
            int idfactura = Convert.ToInt32(IDnumericUpDown.Value);
            if(SetError(1))
            {
                MessageBox.Show("Llenar Id");
                return;
            }

            var bill = BLL.FacturacionBLL.Buscar(Convert.ToInt32(IDnumericUpDown.Value));
            if(bill!=null)
            {
                ClienteIdnumericUpDown.Value = bill.ClienteId;
                UsuarioIdnumericUpDown.Value = bill.UsuarioId;
                FormaDePagocomboBox.Text = bill.FormaDePago;
                DescripciponFacturatextBox.Text = bill.Descripcion;
                DevueltatextBox.Text = bill.Devuelta.ToString();
                MontotextBox.Text = bill.Monto.ToString();
                Monto = bill.Monto;
                FechadateTimePicker.Value = bill.Fecha;
                EfectivonumericUpDown.Value = bill.EfectivoRecibido;
                billes.BillDetalle = BLL.FacturaDetalleBLL.GetList(x => x.FacturaId == idfactura);
                foreach (var item in billes.BillDetalle)
                {
                    item.Importe = BLL.FacturacionBLL.Importe(item.Cantidad, item.Precio);
                }
                FacturadataGridView.DataSource = billes.BillDetalle;
                billes.BillDetalle = new List<FacturaDetalle>();
                BuscarDetalllebutton.Enabled = true;
                DetallenumericUpDown.Enabled = true;
            }
            else
            {
                MessageBox.Show("Factura no encontrada");
            }
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var persona = BLL.FacturacionBLL.Buscar(Convert.ToInt32(IDnumericUpDown.Value));
       
            LimpiarProvider();
            if (SetError(1))
            {
                MessageBox.Show("Llenar campos Vacios");
                return;
            }
            if ( BLL.FacturacionBLL.Eliminar(Convert.ToInt32(IDnumericUpDown.Value)))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }


        }

        private void BuscarArticulobutton_Click(object sender, EventArgs e)
        {
            CantidadnumericUpDown.Value = 0;
            ImportetextBox.Clear();
            LimpiarProvider();
            if (SetError(3))
            {
                MessageBox.Show("Llenar Id");
                return;
            }

            var producto = BLL.ProductoBLL.Buscar(Convert.ToInt32(ProductoIDnumericUpDown.Value));
            if (producto != null)
            {
                DescripcionProductotextBox.Text = producto.Descripcion;
                PreciotextBox.Text = producto.Precio.ToString();

            }
            else
            {
                MessageBox.Show("Factura no encontrada");
            }
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            ImportetextBox.Text = BLL.FacturacionBLL.Importe(CantidadnumericUpDown.Value, Convert.ToDecimal(PreciotextBox.Text)).ToString();
        }

        private void EfectivonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AsignarDevuelta();
        }

        private void AsignarDevuelta()
        {
            decimal devuelta = BLL.FacturacionBLL.CalcularDevuelta(EfectivonumericUpDown.Value, Convert.ToDecimal(MontotextBox.Text));
            DevueltatextBox.Text = devuelta.ToString();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            int idfactura = Convert.ToInt32(IDnumericUpDown.Value);
            

            if (BLL.ProductoBLL.Buscar(Convert.ToInt32(ProductoIDnumericUpDown.Value)).Cantidad - Convert.ToInt32(CantidadnumericUpDown.Value) < 0)
            {
                MessageBox.Show("Cantidad insuficiente del producto solicitado");
                MessageBox.Show("Disponibles "+BLL.ProductoBLL.Buscar(Convert.ToInt32(ProductoIDnumericUpDown.Value)).Cantidad.ToString());
                return;
            }
            if(IDnumericUpDown.Value ==0)
            {
                billes.BillDetalle.Add(new FacturaDetalle(0, billes.FacturaId, Convert.ToInt32(ProductoIDnumericUpDown.Value), Convert.ToInt32(CantidadnumericUpDown.Value), Convert.ToDecimal(PreciotextBox.Text), DescripcionProductotextBox.Text, Convert.ToDecimal(ImportetextBox.Text)));
                
            }
            else
            {
          
                 billes.BillDetalle = BLL.FacturaDetalleBLL.GetList(x => x.FacturaId == idfactura);
                 Monto -= BLL.FacturacionBLL.DescontarImporte(billes.BillDetalle, Convert.ToInt32(DetallenumericUpDown.Value));
                foreach (var item in billes.BillDetalle)
                {
                    item.Importe = BLL.FacturacionBLL.Importe(item.Cantidad, item.Precio);
                }
                billes.BillDetalle = BLL.FacturacionBLL.Editar(billes.BillDetalle, new FacturaDetalle(Convert.ToInt32(DetallenumericUpDown.Value), Convert.ToInt32(IDnumericUpDown.Value), Convert.ToInt32(ProductoIDnumericUpDown.Value), Convert.ToInt32(CantidadnumericUpDown.Value), Convert.ToDecimal(PreciotextBox.Text), DescripcionProductotextBox.Text, Convert.ToDecimal(ImportetextBox.Text)));
               
                
            }

            Monto += BLL.FacturacionBLL.CalcularMonto(Convert.ToDecimal(ImportetextBox.Text));
            MontotextBox.Text = Monto.ToString();
            AsignarDevuelta();
            FacturadataGridView.DataSource = null;
            FacturadataGridView.DataSource = billes.BillDetalle;
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            CFactura abrir = new CFactura();
            abrir.Show();
        }

        private void BuscarDetalllebutton_Click(object sender, EventArgs e)
        {
            int ID, id;
            int.TryParse(DetallenumericUpDown.Text, out ID);
            id = Convert.ToInt32(IDnumericUpDown.Value);


            LimpiarProvider();
            if (SetError(4))
            {
                MessageBox.Show("Campo Vacio");
                return;
            }

            if (BLL.FacturaDetalleBLL.Buscar(ID) != null)
            {

                DescripcionProductotextBox.Text = BLL.FacturaDetalleBLL.BuscarDetalle(id, ID).Descripcion;
                PreciotextBox.Text = BLL.FacturaDetalleBLL.BuscarDetalle(id, ID).Precio.ToString();
                ProductoIDnumericUpDown.Value = BLL.FacturaDetalleBLL.BuscarDetalle(id, ID).ProductoId;
                CantidadnumericUpDown.Value = BLL.FacturaDetalleBLL.BuscarDetalle(id, ID).Cantidad;

            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }
    }
}
