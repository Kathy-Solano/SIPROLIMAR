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
    public class TipoTelefonoController : ApiController
    {
        ITipoTelefono _tipoTelefono;

        public TipoTelefonoController(ITipoTelefono tipoTelefono)
        {
            _tipoTelefono = tipoTelefono;
        }

        public List<TipoTelefono> get() 
        {
            return _tipoTelefono.getTipoTelefonos();
        }

        public TipoTelefono get(int id) 
        {
            return _tipoTelefono.getTipoTelefono(id);
        }
    }
}
