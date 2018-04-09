using ProyectoFinal.Entidades;
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
    public partial class rLogIn : Form
    {
        public rLogIn()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            IDcomboBox.Items.Clear();
            foreach (var item in BLL.UsuarioBLL.GetList(x => true))
            {
                IDcomboBox.Items.Add(item.IdUsuario);
            }


        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

            Clear();
        }

        private void LimpiarError()
        {
            IDerrorProvider.Clear();
            UsuarioerrorProvider.Clear();
            NombreerrorProvider.Clear();
            ContraseñaerrorProvider.Clear();
            ComentarioerrorProvider.Clear();
        }

        private int SetError(int error)
        {
           
            int paso = 0;
            List<Usuario> user = new List<Usuario>();
            if (error == 1 && IDcomboBox.Text ==string.Empty)
            {

                IDerrorProvider.SetError(IDcomboBox, "Llenar Campo!!");
                paso = 1;
                return paso;


            }
            if (error == 2 && UsuariotextBox.Text == string.Empty)
            {
                UsuarioerrorProvider.SetError(UsuariotextBox, "Llenar Campo!!");
                paso = 1;

            }
            if (error == 2 && NombretextBox.Text == string.Empty)
            {
                NombreerrorProvider.SetError(NombretextBox, "Llenar Campo!!");
                paso = 1;
            }
            if (error == 2 && ContraseñatextBox.Text == string.Empty)
            {
                ContraseñaerrorProvider.SetError(ContraseñatextBox, "Llenar Campo!!");
                paso = 1;
            }
            if (error == 2 && ConfirmartextBox.Text == string.Empty)
            {
                ContraseñaerrorProvider.SetError(ConfirmartextBox, "Llenar Campo!!");
                paso = 1;
            }
            if (error == 2 && ComentariotextBox.Text == string.Empty)
            {
                ComentarioerrorProvider.SetError(ComentariotextBox, "Llenar Campo!!");
                paso = 1;
            }
            if (error == 3 && ContraseñatextBox.Text != ConfirmartextBox.Text)
            {
                ContraseñaerrorProvider.SetError(ConfirmartextBox, "Llenar Campo!!");
                ContraseñaerrorProvider.SetError(ContraseñatextBox, "Llenar Campo!!");
                paso = 1;
            }

            if (error == 4 && BLL.UsuarioBLL.GetList(t => t.NombreUsuario == UsuariotextBox.Text).Exists(t => t.NombreUsuario == UsuariotextBox.Text)&& IDcomboBox.Text == string.Empty)
            {
                UsuarioerrorProvider.SetError(UsuariotextBox, "Debe de crear otro usuario!!");
                paso = 1;
            }


            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LimpiarError();
            if (SetError(2) == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            if (SetError(4) == 1&& IDcomboBox.Text==string.Empty)
            {
                MessageBox.Show("Usuario existente!!");
                return;
            }
            Usuario user = LlenaClase();
            if (IDcomboBox.Text == string.Empty)
            {
                if (user == null)
                {
                    return;
                }

                if (BLL.UsuarioBLL.Guardar(user))
                {
                    MessageBox.Show("Guardado!!");
                    IDcomboBox.DataSource = null;
                    LlenarComboBox();
                    Clear();
                }
            }
            else
            {
                if (user == null)
                {
                    return;
                }
                if (SetError(1) == 1)
                {
                    MessageBox.Show("Campos Vacios!!");
                    return;
                }
                if (BLL.UsuarioBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Modificado!!");
                }
            }

        }

        private Usuario LlenaClase()
        {
            Usuario user = new Usuario();
            if(IDcomboBox.Text==string.Empty)
            {

                user.IdUsuario = 0;
            }
            {
                user.IdUsuario = Convert.ToInt32(IDcomboBox.Text);
            }
            
            user.NombreUsuario = UsuariotextBox.Text;
            user.Nombre = NombretextBox.Text;
            if (SetError(3) == 0)
            {
                user.Clave = ContraseñatextBox.Text;
            }
            else
            {
                MessageBox.Show("Las contraseñas son diferentes");
                user = null;
                return user;
            }
            user.Fecha = FechadateTimePicker.Value;
            user.Comentario = ComentariotextBox.Text;





            return user;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarError();
            if (SetError(1) == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            
                if (BLL.UsuarioBLL.Eliminar(Convert.ToInt32(IDcomboBox.Text)))
                {
                    MessageBox.Show("Eliminado");
                    IDcomboBox.DataSource = null;
                    LlenarComboBox();
                    Clear();
            }
                else
                {
                    MessageBox.Show("No se pudo elimianar");
                }
            
            
            
        }

        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarError();
            var user = BLL.UsuarioBLL.Buscar(Convert.ToInt32(IDcomboBox.Text));
            UsuariotextBox.Text = user.NombreUsuario;
            NombretextBox.Text = user.Nombre;
            ConfirmartextBox.Text = user.Clave;
            ContraseñatextBox.Text = user.Clave;
            FechadateTimePicker.Value = user.Fecha;
            ComentariotextBox.Text = user.Comentario;
        }

        private void Clear()
        {
            IDcomboBox.Text = string.Empty;
            UsuariotextBox.Clear();
            NombretextBox.Clear();
            ContraseñatextBox.Clear();
            ConfirmartextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            ComentariotextBox.Clear();
            LimpiarError();
        }
    }
}             
