using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SiprolimarDB.Entities;
using SiprolimarApi.DAL;

namespace SiprolimarApi.Controllers
{
    public class UsuarioController : ApiController
    {
        IUsuario _usuario;

        public UsuarioController(IUsuario usuario)
        {
            _usuario = usuario;
        }

        public List<Usuario> get()
        {
            return _usuario.getUsuarios();
        }

        public Usuario get(string nombre)
        {
            return _usuario.getUsuarioporNombre(nombre);
        }

        public Usuario get(int id)
        {
            return _usuario.getUsuario(id);
        }
        public bool get(string nombre, string password)
        {
            return _usuario.login(nombre, password);
        }
    }
}
