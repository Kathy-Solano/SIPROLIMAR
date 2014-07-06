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
    public class LineaFacturaController: ApiController
    {
         ILineaFactura _lineaFactura;

         public LineaFacturaController(ILineaFactura lineaFactura)
        {
            _lineaFactura = lineaFactura;
        }

        public List<LineaFactura> get()
        {
            return _lineaFactura.getLineaFacturas();
        }

        public LineaFactura get(int id)
        {
            return _lineaFactura.getLineaFacturas(id);
        }
    }
}