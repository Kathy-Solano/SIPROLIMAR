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
    public class ClienteController : ApiController
    {
        ICliente _cliente;

        public ClienteController(ICliente cliente)
        {
            _cliente = cliente;
        }

        public List<Cliente> get()
        {
            return _cliente.getClientes();
        }

        public Cliente get(int id)
        {
            return _cliente.getCliente(id);
        }
    }
}
