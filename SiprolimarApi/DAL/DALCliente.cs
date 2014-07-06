using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public class DALCliente : ICliente
    {
        public List<Cliente> getClientes()
        {
            List<Cliente> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.Cliente.ToList();
            }

            return result;
        }

        public Cliente getCliente(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.Cliente.Where(c => c.idCliente == id).FirstOrDefault();

                return result;
            }
        }
    }
}