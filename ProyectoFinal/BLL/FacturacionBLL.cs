using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal.BLL
{
   public class FacturacionBLL
    {
        public static bool Guardar(Factura bill)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.bill.Add(bill) != null)
                {
                    db.SaveChanges();
                    db.Dispose();
                    paso = true;
                }


            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.bill.Find(Id);
               
                db.Billes.RemoveRange(db.Billes.Where(x => x.FacturaId == eliminar.FacturaId));
                db.Entry(eliminar).State = EntityState.Deleted;
                if (db.SaveChanges() > 0)
                {
                    db.Dispose();
                    paso = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Modificar(Factura bill)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(bill).State = EntityState.Modified;
                foreach (var item in bill.BillDetalle)
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    if (db.SaveChanges() > 0)
                    {
                       
                        paso = true;
                    }
                }

                db.Dispose();

            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public static Factura Buscar(int id)
        {
            Factura bill = new Factura();
            Contexto db = new Contexto();
            try
            {

                bill = db.bill.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return bill;
        }

        public static List<Factura> GetList(Expression<Func<Factura, bool>> bill)
        {
            List<Factura> factura = new List<Factura>();
            Contexto db = new Contexto();
            try
            {
                factura = db.bill.Where(bill).ToList();
               
            }
            catch (Exception)
            {

                throw;
            }
            
            return factura;
        }

        

        public static decimal devuelta(decimal monto, decimal efectivo)
        {
            decimal devuelta = 0;

            devuelta = efectivo - monto;
            return devuelta;
        }

        public static decimal CalcularMonto(decimal importe)
        {
            decimal monto = 0;
            monto += importe;

            return monto;
        }

        public static decimal Importe(decimal cantidad, decimal precio)
        {
            decimal importe = 0;
            importe = cantidad * precio;

            return importe;
        }

        public static void DescontarProductos(List<FacturaDetalle> bill, int cantidad)
        {
            // Descontar cantidad a productos
            

            foreach (var item in bill)
            {
                var producto = BLL.ProductoBLL.Buscar(item.ProductoId);
                
                
                    producto.Cantidad -= item.Cantidad;

                    BLL.ProductoBLL.Modificar(producto);
      
            }

        }

        public static List<FacturaDetalle> Editar(List<FacturaDetalle> list, FacturaDetalle factura)
        {
            foreach (var item in list)
            {
                if(item.Id ==factura.Id)
                {
                    item.Cantidad = factura.Cantidad;
                }

            }

            return list;
        }

        public static decimal DescontarImporte(List<FacturaDetalle> list,int id)
        {
            decimal monto = 0;
            foreach (var item in list)
            {
                if(item.Id == id)
                {
                    item.Importe = item.Cantidad * item.Precio;
                    monto = item.Importe;
                }
                
            }

            return monto;
        }

        public static decimal CalcularDevuelta(decimal efectivo, decimal monto)
        {
            decimal devuelta = 0;

            devuelta = efectivo - monto;
            return devuelta;
        }
       


    }
}
