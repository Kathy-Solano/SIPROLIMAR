using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
   public interface IRol
    {
        List<Rol> GetRoles();
        Rol GetRol(int id);
    }
}
