using ProyectoFinal.Entidades;
using ProyectoFinal.Productos;
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
    public partial class rDepartamento : Form
    {
     
        public rDepartamento()
        {
            InitializeComponent();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if(SetError(1))
            {
                MessageBox.Show("Digite el ID");
                return;
            }

            if(BLL.DepartamentoBLL.Eliminar(Convert.ToInt32(IdnumericUpDown.Value)))
            {
                MessageBox.Show("Eliminado!!");
                return;
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            IdnumericUpDown.Value = 0;
            LimpiarProvider();
        }

        private void LimpiarProvider()
        {
            IderrorProvider.Clear();
            DemaserrorProvider.Clear();
        }

        private bool SetError(int error)
        {
            bool paso = false;
            if (error==1&&IdnumericUpDown.Value ==0)
            {
                IderrorProvider.SetError(IdnumericUpDown, "Llenar Campo Id");
                paso = true;
            }
            if (error ==2&&NombretextBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(NombretextBox, "Llenar Nombre");
                paso = true;
            }

            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(2))
            {
                MessageBox.Show("Llenar los campos Vacios!!");
                return;
            }
            Departamento depo = LlenaClase();

            if(IdnumericUpDown.Value==0)
            {
                if (BLL.DepartamentoBLL.Guardar(depo))
                {
                    MessageBox.Show("Guardado!!");
                    
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!!");
                    return;
                }

            }
            else
            {
                if(BLL.DepartamentoBLL.Modificar(LlenaClase()))
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

        private Departamento LlenaClase()
        {
            Departamento depo = new Departamento();

            depo.IdDepartamento = Convert.ToInt32(IdnumericUpDown.Value);
            depo.Nombre = NombretextBox.Text;
            return depo;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            Departamento depo = new Departamento();
            if (SetError(1))
            {
                MessageBox.Show("Llenar Campos faltantes");
                return;
            }

            depo = BLL.DepartamentoBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));
            if (depo != null)
            {
                NombretextBox.Text = depo.Nombre;
            }
            else
            {
                MessageBox.Show("Departamento no encontrado!!");
                return;
            }
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            CDepartamento abrir = new CDepartamento();
            abrir.Show();
        }

    }
}
