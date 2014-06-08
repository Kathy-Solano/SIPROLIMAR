using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public interface ITamannoProducto
    {
        List<TamannoProducto> getTamaños();
        TamannoProducto getTamaño(int id);
    }
}
