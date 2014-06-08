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
    public class ProductoController : ApiController
    {
        IProducto _producto;

        public ProductoController(IProducto producto)
        {
            _producto = producto;
        }

        public List<Producto> get()
        {
            return  _producto.getProductos();
        }

        public Producto get(int id)
        {
            return _producto.getProducto(id);
        }
    }
}
