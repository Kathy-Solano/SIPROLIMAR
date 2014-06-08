using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public interface IFactura
    {
        List<Factura> getFacturas();
        Factura getFactura(int id);
    }
}
