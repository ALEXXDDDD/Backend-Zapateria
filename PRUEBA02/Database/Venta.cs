using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("ventas")]
    [Index("ComprobanteIdComprobante", Name = "fk_ventas_comprobante1_idx")]
    [Index("UsuarioIdUsuario", Name = "fk_ventas_usuario1_idx")]
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        [Key]
        [Column("id_Ventas")]
        public int IdVentas { get; set; }
        [StringLength(100)]
        public string? Articulo { get; set; }
        public float? Monto { get; set; }
        public int? Cantidad { get; set; }
        [Column("usuario_id_Usuario")]
        public int UsuarioIdUsuario { get; set; }
        [Column("comprobante_id_Comprobante")]
        public int ComprobanteIdComprobante { get; set; }

        [ForeignKey("ComprobanteIdComprobante")]
        [InverseProperty("Venta")]
        public virtual Comprobante ComprobanteIdComprobanteNavigation { get; set; } = null!;
        [ForeignKey("UsuarioIdUsuario")]
        [InverseProperty("Venta")]
        public virtual Usuario UsuarioIdUsuarioNavigation { get; set; } = null!;
        [InverseProperty("VentasIdVentasNavigation")]
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
