using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public class DALCliente_TipoTelefono: ICliente_TipoTelefono
    {
        public List<Cliente_TipoTelefono> getClienteTipoTelefonos()
        {
            List<Cliente_TipoTelefono> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.Cliente_TipoTelefono.ToList();
            }

            return result;
        }

        public Cliente_TipoTelefono getClienteTipoTelefono(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.Cliente_TipoTelefono.Where(t => t.cliente == id).FirstOrDefault();

                return result;
            }
        }
    }
}