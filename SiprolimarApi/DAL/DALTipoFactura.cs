using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public class DALTipoFactura : ITipoFactura
    {
        public List<TipoFactura> getTipoFacturas()
        {
            List<TipoFactura> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.TipoFactura.ToList();
            }

            return result;
        }

        public TipoFactura getTipoFactura(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.TipoFactura.Where(tf => tf.idTipoFactura == id).FirstOrDefault();

                return result;
            }
        }
    }
}
