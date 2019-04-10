using DTO;
using Infrestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrestructure.Repository
{
   public class VerntasRepository
    {
        private YooinEnterpriseEntities conn;

        public async Task<bool> SetProducto(VentasDTO[] request)
        {
            try
            {
                
                using (conn = new YooinEnterpriseEntities())
                {
                    foreach(VentasDTO ventas in request)
                    {
                        VentasDTO venta = new VentasDTO();
                        venta.ProductoId = ventas.ProductoId;
                        venta.NombreProducto = ventas.NombreProducto;
                        venta.Piezas = ventas.Piezas;
                        venta.Precio = ventas.Precio;
                        venta.Total = ((ventas.Piezas) * (ventas.Precio));

                        conn.Ventas.Add(venta);
                        await conn.SaveChangesAsync();
                    }
                    


                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
