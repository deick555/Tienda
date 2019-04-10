using DTO;
using Infrestructure.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrestructure.Repository
{
  
   public class InventarioRepository
    {
        private YooinEnterpriseEntities conn;

        public async Task<bool>SetProducto(InventarioDTO request)
        {            
            try
            {
                using(conn = new YooinEnterpriseEntities())
                {
                    InventarioDTO inventario = new InventarioDTO();

                    inventario.NameProduct = request.NameProduct;
                    inventario.Piezas = request.Piezas;
                    inventario.Precio = request.Precio;

                    conn.Inventario.Add(inventario);
                    conn.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateInventarioPiezas(InventarioDTO request)
        {
            try
            {
                const string UpdatePiezas = "Sp_PiezasInventario_Upd";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conDb"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand(UpdatePiezas, conn);
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    command.Parameters.AddWithValue("@Id", request.Id);
                    command.Parameters.AddWithValue("@Piezas", request.Piezas);

                    command.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
            
        }

        public async Task<bool> UpdateInventarioPrecio(InventarioDTO request)
        {
            try
            {
                const string UpdatePrecio = "SP_UpdatePrecio_Upd";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conDb"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand(UpdatePrecio, conn);
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    command.Parameters.AddWithValue("@Id", request.Id);
                    command.Parameters.AddWithValue("@Precio", request.Precio);

                    command.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool>DeleteProducto(int id)
        {
            try
            {
                InventarioDTO inventario = new InventarioDTO() { Id = id };
                using (conn = new YooinEnterpriseEntities())
                {
                    conn.Inventario.Attach(inventario);
                    conn.Inventario.Remove(inventario);
                    conn.SaveChanges();
                }

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public async Task<InventarioDTO[]> GetAllProducto()
        {
            try
            {
                using(conn = new YooinEnterpriseEntities())
                {
                    InventarioDTO[] inventario = (from i in conn.Inventario                                                
                                                  select i).ToArray();
                    return inventario;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<InventarioDTO> GetProductobyId(int id)
        {
            try
            {
                using (conn = new YooinEnterpriseEntities())
                {
                    InventarioDTO inventario = (from i in conn.Inventario
                                                where i.Id == id
                                                select i).FirstOrDefault();
                    return inventario;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
