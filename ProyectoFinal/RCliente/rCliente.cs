using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.RCliente
{
    public partial class rCliente : Form
    {
        public rCliente()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            IDcomboBox.Items.Clear();
            foreach (var item in BLL.ClienteBLL.GetList(x => true))
            {
                IDcomboBox.Items.Add(item.IdCliente);
            }


        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void LimpiarProvider()
        {
            IDerrorProvider.Clear();
            DemaserrorProvider.Clear();
        }

        private bool SetError(int error)
        {
            bool paso = false ;

            if(error ==1&& IDcomboBox.Text == string.Empty)
            {
                IDerrorProvider.SetError(IDcomboBox, "Llenar Id");
                paso = true;
            }
            if(error ==2&&NombretextBox.Text ==string.Empty)
            {
                DemaserrorProvider.SetError(NombretextBox, "Llenar Nombre");
                paso = true;
            }
            if(error ==2&&DirecciontextBox.Text ==string.Empty)
            {
                DemaserrorProvider.SetError(DirecciontextBox, "Llenar Direccion");
                paso = true;
            }
            if(error==2&& CedulamaskedTextBox.MaskFull==false)
            {
                
                DemaserrorProvider.SetError(CedulamaskedTextBox, "Llenar Cedula");
                paso = true;
            }
            if (error == 2&&TelefonomaskedTextBox.MaskFull==false)
            {

                DemaserrorProvider.SetError(TelefonomaskedTextBox, "Llenar Telefono");
                paso = true;
            }
            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if(SetError(2))
            {
                MessageBox.Show("Hay campos vacios");
                return;
            }
            Cliente customer = LlenaClase();

            if(IDcomboBox.Text ==string.Empty)
            {
                if(BLL.ClienteBLL.Guardar(customer))
                {
                    MessageBox.Show("Guardado!!");
                    IDcomboBox.DataSource = null;
                    LlenarComboBox();
                    Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar!!");
                }
            }
            else
            {
                if(BLL.ClienteBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Modificar!!");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar!!");
                }
            }
        }

        private  Cliente LlenaClase()
        {
            Cliente customer = new Cliente();
            if (IDcomboBox.Text == string.Empty)
            {
                customer.IdCliente = 0;
            }
            else
            {
                customer.IdCliente = Convert.ToInt32(IDcomboBox.Text);

            }    
            customer.Nombre = NombretextBox.Text;
            customer.Direccion = DirecciontextBox.Text;
            customer.Cedula = CedulamaskedTextBox.Text;
            customer.Telefono = TelefonomaskedTextBox.Text;

            return customer;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if(SetError(1))
            {
                MessageBox.Show("Llenar Campo Id");
                return;
            }

            if(BLL.ClienteBLL.Eliminar(Convert.ToInt32(IDcomboBox.Text)))
            {
                MessageBox.Show("Eliminado!!");
                IDcomboBox.DataSource = null;
                LlenarComboBox();
                Clear();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!");
            }
        }

        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            var customer = BLL.ClienteBLL.Buscar(Convert.ToInt32(IDcomboBox.Text));
            NombretextBox.Text = customer.Nombre;
            DirecciontextBox.Text = customer.Direccion;
            CedulamaskedTextBox.Text = customer.Cedula;
            TelefonomaskedTextBox.Text = customer.Telefono;
        }

        private void Clear()
        {
            IDcomboBox.Text = string.Empty;
            NombretextBox.Clear();
            DirecciontextBox.Clear();
            CedulamaskedTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            LimpiarProvider();
        }
    }
}
