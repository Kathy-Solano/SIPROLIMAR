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
    public class TamannoProductoController : ApiController
    {
        ITamannoProducto _tamañoProducto;

        public TamannoProductoController(ITamannoProducto tamañoProducto)
        {
            _tamañoProducto = tamañoProducto;
        }

        public List<TamannoProducto> get()
        {
            return _tamañoProducto.getTamaños();
        }

        public TamannoProducto get(int id)
        {
            return _tamañoProducto.getTamaño(id);
        }
    }
}
