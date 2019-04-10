using DTO;
using Infrestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian
{
   public class ClientesBO
    {
        private ClientesRepository clientesRepository;

        public ClientesBO()
        {
            clientesRepository = new ClientesRepository();
        }

        public async Task<bool>SetCliente(ClientesDTO request)
        {
            return await clientesRepository.SetCliente(request);
        }

        public async Task<ClientesDTO[]> GetClientes()
        {
            return await clientesRepository.GetClientes();
        }

    }
}
