using ProyectoFinal.RDepartamento;
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
    public partial class rProductos : Form
    {
     
        public rProductos()
        {
            InitializeComponent();
            
            AgregarAComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            DepartamentocomboBox.Text =string.Empty ;
            CantidadnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
        }

        private bool SetError(int error)
        {
            bool paso = false;
            if(error ==1&&IdnumericUpDown.Value==0)
            {
                IderrorProvider.SetError(IdnumericUpDown, "Llenar Id");
                paso = true;
            }
            if(error==2&&PrecionumericUpDown.Value==0)
            {
                DemasCamposerrorProvider.SetError(PrecionumericUpDown, "LLenar Precio");
                paso = true;
            }
            if (error == 2 && DepartamentocomboBox.Text ==string.Empty )
            {
                DemasCamposerrorProvider.SetError(DepartamentocomboBox, "LLenar Departamento");
                paso = true;
            }
            if (error == 2 && CantidadnumericUpDown.Value == 0)
            {
                DemasCamposerrorProvider.SetError(CantidadnumericUpDown, "LLenar Cantidad");
                paso = true;
            }
            if (error == 2 && DescripciontextBox.Text == string.Empty)
            {
                DemasCamposerrorProvider.SetError(DescripciontextBox, "LLenar Descripcion");
                paso = true;
            }


            return paso;
        }

        private void LimpiarProvider()
        {
            IderrorProvider.Clear();
            DemasCamposerrorProvider.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if(SetError(2))
            {
                MessageBox.Show("LLenar Los Campos Vacios");
                return;
            }
            Producto product = LlenaClase();
            if(IdnumericUpDown.Value==0)
            {
                if(BLL.ProductoBLL.Guardar(product))
                {
                    MessageBox.Show("Guardado!!");
                    return;
                }
                else
                {
                    MessageBox.Show("No se Guardo!!");
                    return;
                }
            }
            else
            {
                if(BLL.ProductoBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Modificado!!");
                    return;
                }
                else
                {
                    MessageBox.Show("No se pudo modificar!!");
                    return;
                }
            }
        }

        private Producto LlenaClase()
        {
            Producto producto = new Producto();
            producto.Idproducto = Convert.ToInt32(IdnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            producto.Precio = PrecionumericUpDown.Value;
            producto.DepartamentoId = DepartamentocomboBox.SelectedIndex + 1;
            return producto;
            
        }

        public void AgregarAComboBox()
        {

            Expression<Func<Departamento, bool>> filtrar = x => true;
            List<Departamento> tipo = new List<Departamento>();
            tipo = BLL.DepartamentoBLL.GetList(filtrar);
            DepartamentocomboBox.Items.Clear();
            foreach (var tel in tipo)
            {
                DepartamentocomboBox.Items.Add(tel.Nombre);
        
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if(SetError(1))
            {
                MessageBox.Show("Llenar Id");
                return;
            }
            var producto = BLL.ProductoBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));
            if(producto!=null)
            {
                PrecionumericUpDown.Value = producto.Precio;
                CantidadnumericUpDown.Value = producto.Cantidad;
                DepartamentocomboBox.Text = BLL.DepartamentoBLL.Buscar(producto.DepartamentoId).Nombre;
                DescripciontextBox.Text = producto.Descripcion;
            }
            else
            {
                MessageBox.Show("Producto no Encontrado!!");
                return;
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if(SetError(1))
            {
                MessageBox.Show("Llenar campo Id");
                return;
            }

            if(BLL.ProductoBLL.Eliminar(Convert.ToInt32(IdnumericUpDown.Value)))
            {
                MessageBox.Show("Eliminado!!");
                return;
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!");
                return;
            }
        }

        private void COnsultabutton_Click(object sender, EventArgs e)
        {
            CProducto abrir = new CProducto();
            abrir.Show();
        }

      

       
    }
}
