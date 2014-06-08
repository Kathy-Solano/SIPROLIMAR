using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;


namespace SiprolimarApi.DAL
{
    public class DALTamannoProducto : ITamannoProducto
    {
        public List<TamannoProducto> getTamaños()
        {
            List<TamannoProducto> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.TamannoProducto.ToList();
            }

            return result;
        }

        public TamannoProducto getTamaño(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.TamannoProducto.Where(tp => tp.idTamaño == id).FirstOrDefault();

                return result;
            }
        }
    }
}
