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
    [RoutePrefix("Ventas")]
    public class VentasController : ApiController
    {
        private VentasBO ventasBO;

        public VentasController()
        {
            ventasBO = new VentasBO();
        }
        [HttpPost]
        [Route("")]
        public async Task<HttpResponseMessage> SetVenta([FromBody] VentasDTO[] request)
        {
            bool resutl = await ventasBO.SetVentas(request);

            if (resutl)
                return Request.CreateResponse(HttpStatusCode.OK);
            else
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
