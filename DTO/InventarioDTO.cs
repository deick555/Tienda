using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("Inventario")]
   public class InventarioDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NameProduct")]
        public string NameProduct { get; set; }

        [Column("Piezas")]
        public int Piezas { get; set; }

        [Column("Precio")]
        public double Precio { get; set; }
    }
}





