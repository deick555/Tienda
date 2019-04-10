using Domian;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProyectoTienda.Controllers
{
    [RoutePrefix("Clientes")]
    public class ClientesController : ApiController
    {
        private ClientesBO clientesBO;

        public ClientesController()
        {
            clientesBO = new ClientesBO();
        }

        [HttpPost]
        [Route("nuevoCliente")]
        public async Task<HttpResponseMessage> SetCliente([FromBody] ClientesDTO request)
        {
            bool resutl = await clientesBO.SetCliente(request);

            if (resutl)
                return Request.CreateResponse(HttpStatusCode.OK);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [HttpGet]
        [Route("consulta")]
        public async Task<HttpResponseMessage> GetAllClientes()
        {
            ClientesDTO[] response = await clientesBO.GetClientes();

            if (response != null)
                return Request.CreateResponse(HttpStatusCode.OK, response);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
