using DTO;
using Infrestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian
{
    public class InventarioBO
    {

        private InventarioRepository inventarioRepository;

        public InventarioBO()
        {
            inventarioRepository = new InventarioRepository();
        }

        public async Task<bool> SetProducto(InventarioDTO request)
        {
            return await inventarioRepository.SetProducto(request);
        }      

        public async Task<bool> DeleteProducto(int id)
        {
            bool result = await inventarioRepository.DeleteProducto(id);
            return result;
        }

        public async Task<InventarioDTO[]> GetAllProducto()
        {
            return await inventarioRepository.GetAllProducto();
        }

        public async Task<InventarioDTO> GetProductobyId(int id)
        {
            return await inventarioRepository.GetProductobyId(id);
        }
        public async Task<bool> EntradasInventario(InventarioDTO request)
        {
            bool response = false;
            if (request.Precio != 0)
            {                
                response = await inventarioRepository.UpdateInventarioPrecio(request);          
            }

            if(request.Piezas != 0)
            {
                InventarioDTO getProductobyId = await inventarioRepository.GetProductobyId(request.Id);
                InventarioDTO res = new InventarioDTO();

                res.Id = request.Id;
                res.Piezas = request.Piezas + getProductobyId.Piezas;

                response = await inventarioRepository.UpdateInventarioPiezas(res);                
            }

            return response;
        }

        public async Task<bool> SalidasInventario(InventarioDTO request)
        {
            bool response = false;           

            if (request.Piezas != 0)
            {
                InventarioDTO getProductobyId = await inventarioRepository.GetProductobyId(request.Id);
                InventarioDTO res = new InventarioDTO();

                res.Id = request.Id;

                if ((getProductobyId.Piezas - request.Piezas < 0))
                    res.Piezas = 0; 
                else
                    res.Piezas = getProductobyId.Piezas - request.Piezas;
                response = await inventarioRepository.UpdateInventarioPiezas(res);
            }

            return response;
        }






    }        
}
