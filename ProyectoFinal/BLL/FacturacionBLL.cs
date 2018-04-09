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
        private static  Usuario user = new Usuario();

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

        public static bool GuardarDetalle(FacturaDetalle bill)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Billes.Add(bill) != null)
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
                if (eliminar!=null)
                {
                    db.Billes.RemoveRange(db.Billes.Where(x => x.FacturaId == eliminar.FacturaId));
                    db.Entry(eliminar).State = EntityState.Deleted;
                    if (db.SaveChanges() > 0)
                    {
                        db.Dispose();
                        paso = true;
                    }
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
            bool paso1 = false;
            Contexto db = new Contexto();
            try
            {
                var billes = Buscar(bill.FacturaId);
                db.Entry(bill).State = EntityState.Modified;
                
                ArreglarProducto(billes);
                foreach (var item in bill.BillDetalle)
                {
                    if(item.Id==0)
                    {
                        GuardarDetalle(item);
                    }
                    else
                    {
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() > 0)
                        {
                            paso1 = true;
                            paso = true;
                        }
                    }
                  
                    
                }
                if (paso1 == false)
                {
                    if (db.SaveChanges() > 0)
                    {
                        
                        paso = true;
                    }
                }
                DescontarProductos(Buscar(bill.FacturaId).BillDetalle);

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
                if(bill!=null)
                {
                    bill.BillDetalle.Count();
                }
                
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
                foreach (var item in factura)
                {
                    item.BillDetalle.Count();
                }

                db.Dispose();

               
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

        public static decimal Importe(decimal cantidadDefecto,decimal cantidad, decimal precio, int id, int ID)
        {
            decimal importe = 0;
            if (ID == id)
            {

                importe = cantidad * precio;
            }
            else
            {
                importe = cantidadDefecto * precio;
            }
            

            return importe;
        }

        public static decimal Importedemas(decimal cantidad, decimal precio)
        {
            decimal importe = 0;
           
            
                importe = cantidad * precio;
            


            return importe;
        }

        public static void DescontarProductos(List<FacturaDetalle> bill)
        {
            // Descontar cantidad a productos
            

            foreach (var item in bill)
            {
                var producto = BLL.ProductoBLL.Buscar(item.ProductoId);
                
                
                    producto.Cantidad -= item.Cantidad;

                    BLL.ProductoBLL.Modificar(producto);
      
            }

        }

        public static void ArreglarProducto(Factura bill)
        {
            foreach (var item in bill.BillDetalle)
            {
                var producto = BLL.ProductoBLL.Buscar(item.ProductoId);

                producto.Cantidad += item.Cantidad;

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

        public static int Mayor(List<Factura> bill)
        {
            int mayor = 0;
            foreach (var item in bill)
            {
                if(mayor==0)
                {
                    mayor = item.FacturaId;
                }else
                {
                    if(mayor< item.FacturaId)
                    {
                        mayor = item.FacturaId;
                    }
                }
                
            }

            return mayor;
        }

        public static void NombreLogin(string nombre, int id)
        {
             user.Nombre = nombre;
            user.IdUsuario = id;
        }
        
        public static Usuario returnUsuario()
        {
            return user;
        }
       
        public static decimal RetornarDevuelta( decimal efectivo, decimal monto)
        {
            decimal devuelta = CalcularDevuelta(efectivo, monto);

            return devuelta;
        }

    }
}
