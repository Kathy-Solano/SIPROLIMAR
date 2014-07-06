using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiprolimarDB.Entities;
using System.Web.Http;
using System.Web.Security;
using System.Security.Principal;
using System.Web.Helpers;


namespace SiprolimarApi.DAL
{
    public class DALUsuario : IUsuario
    {
        public List<Usuario> getUsuarios() 
        {
            List<Usuario> result;
            using (var context = new SIPROLIMAREntities())
            {
                result = context.Usuario.ToList();
            }

            return result;
        }

        public Usuario getUsuarioporNombre(string nombre)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.Usuario.Where(u => u.nombreUsuario == nombre).FirstOrDefault();

                return result;
            }
        }

        public bool login(string nombre, string password)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.Usuario.Where(u => u.nombreUsuario == nombre && u.contrasenna == password).FirstOrDefault();

                if (result != null)
                {
                    return true;
                }
                else return false;
            }
        }
        public Usuario getUsuario(int id)
        {
            using (var context = new SIPROLIMAREntities())
            {

                var result = context.Usuario.Where(u => u.idUsuario == id).FirstOrDefault();

                return result;
            }
        }
    }
}
