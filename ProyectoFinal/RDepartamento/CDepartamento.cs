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

namespace ProyectoFinal.RDepartamento
{
    public partial class CDepartamento : Form
    {
        public CDepartamento()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;


            Expression<Func<Departamento, bool>> filtrar = x => true;

            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.DepartamentoId == id;
                    break;
                //Descripcion
                case 1:

                    filtrar = t => t.Nombre.Contains(CriteriotextBox.Text);
                    break;
            }
 
            ConsultadataGridView.DataSource = BLL.DepartamentoBLL.GetList(filtrar);
        }
    }
}
