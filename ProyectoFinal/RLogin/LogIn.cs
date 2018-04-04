using ProyectoFinal.Entidades;
using ProyectoFinal.MasVentas;
using ProyectoFinal.RLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            int paso = 0;
            Expression<Func<Usuario, bool>> filtrar = x => true;
            List<Usuario> user = new List<Usuario>();

            limpiarError();
            
            if (UsuariologtextBox.Text == string.Empty)
            {
                paso = 1;
                LogInerrorProvider.SetError(UsuariologtextBox, "Incorrecto");

            }
            if (ClavetextBox.Text == string.Empty)
            {
                paso = 1;
                LogInerrorProvider.SetError(ClavetextBox, "Incorrecto");

            }
            if (paso == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }

            filtrar = t => t.NombreUsuario.Equals(UsuariologtextBox.Text);
            user = BLL.UsuarioBLL.GetList(filtrar);

            if (user.Exists(x => x.NombreUsuario == UsuariologtextBox.Text) && user.Exists(x => x.Clave == ClavetextBox.Text))
            {

                MasVenta abrir = new MasVenta();
                abrir.Show();

            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
                LogInerrorProvider.SetError(ClavetextBox, "Incorrecto");
                LogInerrorProvider.SetError(UsuariologtextBox, "Incorrecto");

            }
            ClavetextBox.MaxLength = 14;

        }

        void limpiarError()
        {
            LogInerrorProvider.Clear();
            LogInerrorProvider.Clear();
        }
    }
    
}
