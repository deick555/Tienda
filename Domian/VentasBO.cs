using DTO;
using Infrestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian
{
    public class VentasBO
    {
        private InventarioRepository inventarioRepository;
        private VerntasRepository ventasRepository;
        private InventarioBO inventarioBo;

        public VentasBO()
        {
            inventarioRepository = new InventarioRepository();
            ventasRepository = new VerntasRepository();
            inventarioBo = new InventarioBO();
        }

        public async Task<bool>SetVentas(VentasDTO[] request)
        {
            bool response = false;

             response = await ventasRepository.SetProducto(request);
            if (response)
            {
                foreach(VentasDTO ventas in request)
                {
                    InventarioDTO inventario = new InventarioDTO();

                    inventario.Piezas = ventas.Piezas;
                    inventario.Id = ventas.ProductoId;
                    response = await inventarioBo.SalidasInventario(inventario);
                }
                
                return response;
            }
            else
                return response;
        }
    }
}
