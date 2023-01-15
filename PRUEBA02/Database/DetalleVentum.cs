using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("detalle_venta")]
    [Index("VentasIdVentas", Name = "fk_detalle_venta_ventas1_idx")]
    public partial class DetalleVentum
    {
        [Key]
        [Column("id_detalle_venta")]
        public int IdDetalleVenta { get; set; }
        [Column("categoria")]
        public int? Categoria { get; set; }
        [Column("detalle")]
        [StringLength(45)]
        public string? Detalle { get; set; }
        [Column("tipo_comprobante")]
        [StringLength(45)]
        public string? TipoComprobante { get; set; }
        [Column("numero_documento")]
        [StringLength(45)]
        public string? NumeroDocumento { get; set; }
        [Column("ventas_id_Ventas")]
        public int VentasIdVentas { get; set; }

        [ForeignKey("VentasIdVentas")]
        [InverseProperty("DetalleVenta")]
        public virtual Venta VentasIdVentasNavigation { get; set; } = null!;
    }
}
