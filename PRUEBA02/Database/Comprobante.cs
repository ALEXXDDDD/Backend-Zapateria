using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("comprobante")]
    public partial class Comprobante
    {
        public Comprobante()
        {
            Venta = new HashSet<Venta>();
        }

        [Key]
        [Column("id_Comprobante")]
        public int IdComprobante { get; set; }
        [StringLength(100)]
        public string Articulo { get; set; } = null!;
        [StringLength(50)]
        public string Cantidad { get; set; } = null!;
        [Column("Precio_Unitario")]
        public float PrecioUnitario { get; set; }
        public float Monto { get; set; }

        [InverseProperty("ComprobanteIdComprobanteNavigation")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
