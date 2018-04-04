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

namespace ProyectoFinal.RLogin
{
    public partial class CLogin : Form
    {
        public CLogin()
        {
            InitializeComponent();
        }
        Expression<Func<Usuario, bool>> filtrar = x => true;
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;


            

            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.IdUsuario == id;
                    break;
                //Nombre
                case 1:

                    filtrar = t => t.Nombre.Contains(CriteriotextBox.Text);
                    break;
                //fecha
                case 2:
                    filtrar = t => (t.Fecha >= AHoradateTimePicker1.Value) && (t.Fecha <= FInaldateTimePicker2.Value);
                    break;
                //Usuario
                case 3:

                    filtrar = t => t.NombreUsuario.Contains(CriteriotextBox.Text);
                    break;
                //Clave
                case 4:

                    filtrar = t => t.Clave.Contains(CriteriotextBox.Text);
                    break;
                //Comentario
                case 5:

                    filtrar = t => t.Comentario.Contains(CriteriotextBox.Text);
                    break;
            }


            ConsultadataGridView.DataSource = BLL.UsuarioBLL.GetList(filtrar);
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            ReporteLogIn abrir = new ReporteLogIn(BLL.UsuarioBLL.GetList(filtrar));
            abrir.Show();
        }
    }
}
