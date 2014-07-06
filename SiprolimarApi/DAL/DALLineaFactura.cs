using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public class DALLineaFactura: ILineaFactura
    {
        public List<LineaFactura> getLineaFacturas()
        {
            List<LineaFactura> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.LineaFactura.ToList();
            }

            return result;
        }

        public LineaFactura getLineaFacturas(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.LineaFactura.Where(c => c.factura == id).FirstOrDefault();

                return result;
            }
        }
    }
}