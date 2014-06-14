using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public class DALTipoTelefono : ITipoTelefono
    {
        
        public List<TipoTelefono> getTipoTelefonos()
        {
            List<TipoTelefono> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.TipoTelefono.ToList();
            }

            return result;
        }

        public TipoTelefono getTipoTelefono(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.TipoTelefono.Where(t => t.idTipoTelefono == id).FirstOrDefault();

                return result;
            }
        }

    }
}