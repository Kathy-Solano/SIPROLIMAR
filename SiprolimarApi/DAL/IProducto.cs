using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public interface IProducto
    {
        List<Producto> getProductos();
        Producto getProducto(int id);
        bool UpdateProducto(int id, Producto producto);
        bool InsertProducto(Producto producto);
    }
}
