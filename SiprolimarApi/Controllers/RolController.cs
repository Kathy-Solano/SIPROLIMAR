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
    public class RolController : ApiController
    {
         IRol _rol;

         public RolController(IRol rol)
        {
            _rol = rol;
        }

        public List<Rol> get()
        {
            return _rol.GetRoles();
        }

        public Rol get(int id)
        {
            return _rol.GetRol(id);
        }
    }
}
