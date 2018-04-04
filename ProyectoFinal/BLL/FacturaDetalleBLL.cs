using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal.BLL
{
    public class FacturaDetalleBLL
    {

        
        public static List<FacturaDetalle> GetList(Expression<Func<FacturaDetalle, bool>> bill)
        {
            List<FacturaDetalle> factura = new List<FacturaDetalle>();
            Contexto db = new Contexto();
            try
            {
                factura = db.Billes.Where(bill).ToList();
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return factura;
        }

        public static FacturaDetalle BuscarDetalle(int id, int ID)
        {
            List<FacturaDetalle> detalle = new List<FacturaDetalle>();
            FacturaDetalle cotisar = new FacturaDetalle();
            detalle = GetList(tt => tt.FacturaId == id);

            foreach (var lista in detalle)
            {
                if (lista.Id == ID)
                {

                    var articulo = BLL.ProductoBLL.Buscar(lista.ProductoId);
                    lista.Descripcion = articulo.Descripcion;
                    cotisar = lista;
                    break;
                }
            }
            return cotisar;

        }

        public static FacturaDetalle Buscar(int id)
        {
            FacturaDetalle bill = new FacturaDetalle();
            Contexto db = new Contexto();
            try
            {

                bill = db.Billes.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return bill;
        }
    }
}
