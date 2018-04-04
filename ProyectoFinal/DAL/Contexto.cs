using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> user { get; set; }
        public DbSet<Producto> product { get; set; }
        public DbSet<Departamento> Depart { get; set; }
        public DbSet<Cliente> customer { get; set; }
        public DbSet<Factura> bill { get; set; }
        public DbSet<FacturaDetalle> Billes { get; set; }


        public Contexto() : base("ConStr")
        {
        }
    }
}
