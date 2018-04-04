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
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Clear();
            DirecciontextBox.Clear();
            CedulamaskedTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            LimpiarProvider();
        }

        private void LimpiarProvider()
        {
            IDerrorProvider.Clear();
            DemaserrorProvider.Clear();
        }

        private bool SetError(int error)
        {
            bool paso = false;
            if(error ==1&&IdnumericUpDown.Value ==0)
            {
                IDerrorProvider.SetError(IdnumericUpDown, "Llenar Id");
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
            if(error==2&&CedulamaskedTextBox.TextLength < 12)
            {
                DemaserrorProvider.SetError(CedulamaskedTextBox, "Llenar Cedula");
                paso = true;
            }
            if(error == 2 &&TelefonomaskedTextBox.TextLength<13)
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

            if(IdnumericUpDown.Value==0)
            {
                if(BLL.ClienteBLL.Guardar(customer))
                {
                    MessageBox.Show("Guardado!!");
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
            customer.IdCliente = Convert.ToInt32(IdnumericUpDown.Value);
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

            if(BLL.ClienteBLL.Eliminar(Convert.ToInt32(IdnumericUpDown.Value)))
            {
                MessageBox.Show("Eliminado!!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if(SetError(1))
            {
                MessageBox.Show("Llenar Campo Id");
                return;
            }
            var customer = BLL.ClienteBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));
            if(customer!=null)
            {
                NombretextBox.Text = customer.Nombre;
                DirecciontextBox.Text = customer.Direccion;
                CedulamaskedTextBox.Text = customer.Cedula;
                TelefonomaskedTextBox.Text = customer.Telefono;

            }
            else
            {
                MessageBox.Show("No se encontro nada!!");
            }
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            cClientes abrir = new cClientes();
            abrir.Show();
        }
    }
}
