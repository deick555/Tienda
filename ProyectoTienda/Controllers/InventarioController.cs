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
    [RoutePrefix("Inventario")]
    public class InventarioController : ApiController
    {
        private InventarioBO inventarioBO;

        public InventarioController()
        {
            inventarioBO = new InventarioBO();
        }

        [HttpPost]
        [Route("nuevoProducto")]
        public async Task<HttpResponseMessage>SetProducto([FromBody] InventarioDTO request)
        {
            bool resutl = await inventarioBO.SetProducto(request);

            if (resutl)
                return Request.CreateResponse(HttpStatusCode.OK);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
        

        [HttpGet]
        [Route("consulta")]
        public async Task<HttpResponseMessage> GetAllProducto()
        {
            InventarioDTO[] response = await inventarioBO.GetAllProducto();

            if (response != null)
                return Request.CreateResponse(HttpStatusCode.OK, response);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [HttpPut]
        [Route("Entradas")]
        public async Task<HttpResponseMessage> EntradasInventario([FromBody]InventarioDTO request )
        {

            bool response = await inventarioBO.EntradasInventario(request);
            if (response)
                return Request.CreateResponse(HttpStatusCode.OK);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [HttpPut]
        [Route("Salidas")]
        public async Task<HttpResponseMessage> SalidasInventario([FromBody]InventarioDTO request)
        {

            bool response = await inventarioBO.SalidasInventario(request);
            if (response)
                return Request.CreateResponse(HttpStatusCode.OK);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [HttpDelete]
        [Route("EliminarProducto/{id}")]
        public async Task<HttpResponseMessage> EliminarProducto([FromUri]int id)
        {

            bool response = await inventarioBO.DeleteProducto(id);
            if (response)
                return Request.CreateResponse(HttpStatusCode.OK);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
