using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("categoria")]
    [Index("DetalleProductoIdDetalleProducto", Name = "fk_Categoria_detalle_producto1_idx")]
    public partial class Categorium
    {
        [Key]
        [Column("id_Categoria")]
        public int IdCategoria { get; set; }
        [StringLength(45)]
        public string? Calzado { get; set; }
        [StringLength(45)]
        public string? Tipo { get; set; }
        [StringLength(45)]
        public string? Genero { get; set; }
        [Column("detalle_producto_id_detalle_producto")]
        public int DetalleProductoIdDetalleProducto { get; set; }

        [ForeignKey("DetalleProductoIdDetalleProducto")]
        [InverseProperty("CategoriaNavigation")]
        public virtual DetalleProducto DetalleProductoIdDetalleProductoNavigation { get; set; } = null!;
    }
}
