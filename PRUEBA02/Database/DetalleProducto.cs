using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("detalle_producto")]
    [Index("ProductoIdProducto", Name = "fk_detalle_producto_Producto1_idx")]
    public partial class DetalleProducto
    {
        public DetalleProducto()
        {
            CategoriaNavigation = new HashSet<Categorium>();
        }

        [Key]
        [Column("id_detalle_producto")]
        public int IdDetalleProducto { get; set; }
        [StringLength(200)]
        public string? Descripcion { get; set; }
        [StringLength(45)]
        public string? Categoria { get; set; }
        [Column("Precio_Unitario")]
        public float? PrecioUnitario { get; set; }
        [Column("IGV")]
        public float? Igv { get; set; }
        [Column("Monto_Total")]
        public float? MontoTotal { get; set; }
        [Column("Producto_id_Producto")]
        public int ProductoIdProducto { get; set; }

        [ForeignKey("ProductoIdProducto")]
        [InverseProperty("DetalleProductos")]
        public virtual Producto ProductoIdProductoNavigation { get; set; } = null!;
        [InverseProperty("DetalleProductoIdDetalleProductoNavigation")]
        public virtual ICollection<Categorium> CategoriaNavigation { get; set; }
    }
}
