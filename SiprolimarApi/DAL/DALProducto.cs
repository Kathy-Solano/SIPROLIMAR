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
    }
}
