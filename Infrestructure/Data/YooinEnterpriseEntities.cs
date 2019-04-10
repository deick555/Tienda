using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infrestructure.Data
{
    public class YooinEnterpriseEntities : DbContext
    {
        public YooinEnterpriseEntities() : base("name=conDb") { }
            
           

        public virtual DbSet<InventarioDTO> Inventario { get; set; }
        public virtual DbSet<VentasDTO> Ventas { get; set; }
        public virtual DbSet<ClientesDTO> Clientes { get; set; }


    }
}
