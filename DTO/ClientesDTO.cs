using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("Clientes")]
   public class ClientesDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Direccion")]
        public string Direccion { get; set; }

        [Column("Telefono")]
        public string Telefono { get; set; }

    }
}
