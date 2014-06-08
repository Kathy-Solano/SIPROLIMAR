using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public class DALFactura : IFactura
    {
        public List<Factura> getFacturas()
        {
            List<Factura> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.Factura.ToList();
            }

            return result;
        }

        public Factura getFactura(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.Factura.Where(f => f.idFactura == id).FirstOrDefault();

                return result;
            }
        }
    }
}
