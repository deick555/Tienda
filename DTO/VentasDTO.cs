using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("Ventas")]
    public class VentasDTO
    {        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("ProductoId")]
        public int ProductoId { get; set; }

        [Column("NombreProducto")]
        public string NombreProducto { get; set; }

        [Column("Piezas")]
        public int Piezas { get; set; }

        [Column("Precio")]
        public float Precio { get; set; }

        [Column("Total")]
        public float Total { get; set; }

    }
}
