using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public class DALProducto : IProducto
    {
        public List<Producto> getProductos()
        {
            List<Producto> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.Producto.ToList();
            }

            return result;
        }

        public Producto getProducto(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.Producto.Where(p =>p.idProducto == id).FirstOrDefault();

                return result;
            }
        }


        public bool UpdateProducto(int id, Producto producto)
        {
            using (var context = new SIPROLIMAREntities())
            {
                var prod = context.Producto.Where(p => p.idProducto == id).FirstOrDefault();
                if (prod != null)
                {
                    prod.nombre = producto.nombre;
                    prod.tamanno = producto.tamanno;
                    prod.cantidadExistencia = producto.cantidadExistencia;
                    prod.precioVenta = producto.precioVenta;

                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool InsertProducto(Producto producto)
        {
            using (var context = new SIPROLIMAREntities())
            {
                var prod = context.Producto.Add(producto);
                if (prod != null)
                {
                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
