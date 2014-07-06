using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public interface IUsuario
    {
        List<Usuario> getUsuarios();
        Usuario getUsuarioporNombre(string nombre);
        Usuario getUsuario(int id);
        bool login(string nombre, string password);
    }
}
