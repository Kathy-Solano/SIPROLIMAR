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
    public class FacturaController : ApiController
    {
        IFactura _factura;

        public FacturaController(IFactura factura)
        {
            _factura = factura;
        }

        public List<Factura> get()
        {
            return _factura.getFacturas();
        }

        public Factura get(int id)
        {
            return _factura.getFactura(id);
        }
    }

}
