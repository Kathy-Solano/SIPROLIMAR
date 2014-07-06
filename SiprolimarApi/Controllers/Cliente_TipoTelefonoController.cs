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
    public class Cliente_TipoTelefonoController: ApiController
    {
        ICliente_TipoTelefono _cliente_tipoTelefono;

        public Cliente_TipoTelefonoController(ICliente_TipoTelefono cliente_TipoTelefono)
        {
            _cliente_tipoTelefono = cliente_TipoTelefono;
        }

        public List<Cliente_TipoTelefono> get() 
        {
            return _cliente_tipoTelefono.getClienteTipoTelefonos();
        }

        public Cliente_TipoTelefono get(int id) 
        {
            return _cliente_tipoTelefono.getClienteTipoTelefono(id);
        }
    }
}