using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public class DALRol : IRol
    {
        public List<Rol> GetRoles()
        {
            //List<Rol> Roles = new List<Rol>();

            //for (var i = 0; i < 10; i++)
            //{
            //    var Rol = new Rol
            //    {
            //        idRol = i,
            //        nombre = "Conejillo " + i
            //    };

            //    Roles.Add(Rol);
            //}

            //return Roles;
            List<Rol> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.Rol.ToList();
            }

            return result;
        }

        public Rol GetRol(int id)
        {
            using(var context = new SIPROLIMAREntities()){

                var result = context.Rol.Where(p => p.idRol == id).FirstOrDefault();

                if (result == null)
                {

                }

                return result;
            }
        }
    }
}