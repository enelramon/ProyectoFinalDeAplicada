using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
   public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

        public Departamento(int idDepartamento, string nombre)
        {
            this.IdDepartamento = idDepartamento;
            this.Nombre = nombre;
        }

        public Departamento()
        {
            this.IdDepartamento = 0;
            this.Nombre = string.Empty;
        }
    }
}
