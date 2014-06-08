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
    public class TipoFacturaController : ApiController
    {
        ITipoFactura _tipoFactura;

        public TipoFacturaController(ITipoFactura tipoFactura)
        {
            _tipoFactura = tipoFactura;
        }

        public List<TipoFactura> get()
        {
            return _tipoFactura.getTipoFacturas();
        }

        public TipoFactura get(int id)
        {
            return _tipoFactura.getTipoFactura(id);
        }
    }
}
