using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiprolimarDB.Entities;

namespace SiprolimarApi.DAL
{
    public interface ICliente_TipoTelefono
    {
        List<Cliente_TipoTelefono> getClienteTipoTelefonos();
        Cliente_TipoTelefono getClienteTipoTelefono(int id);
    }
}