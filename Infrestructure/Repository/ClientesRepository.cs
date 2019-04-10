using DTO;
using Infrestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrestructure.Repository
{
   public class ClientesRepository
    {
        private YooinEnterpriseEntities conn;

        public async Task<bool>SetCliente(ClientesDTO request)
        {
            try
            {
                using(conn = new YooinEnterpriseEntities())
                {
                    ClientesDTO clientes = new ClientesDTO();

                    clientes.Nombre = request.Nombre;
                    clientes.Direccion = request.Direccion;
                    clientes.Telefono = request.Telefono;

                    conn.Clientes.Add(clientes);
                    conn.SaveChanges();

                    return true ;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<ClientesDTO[]> GetClientes()
        {
            return (from c in conn.Clientes
                    select c).ToArray();
        }

    }
}
