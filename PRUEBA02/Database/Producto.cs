using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("producto")]
    [Index("ProveedorIdProveedor", Name = "fk_Producto_proveedor1_idx")]
    [Index("UsuarioIdUsuario", Name = "fk_Producto_usuario1_idx")]
    public partial class Producto
    {
        public Producto()
        {
            DetalleProductos = new HashSet<DetalleProducto>();
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
        [Column("id_Producto")]
        public int IdProducto { get; set; }
        [Column("Producto")]
        [StringLength(50)]
        public string? Producto1 { get; set; }
        [Column("codigo")]
        [StringLength(10)]
        public string? Codigo { get; set; }
        [Column("usuario_id_Usuario")]
        public int UsuarioIdUsuario { get; set; }
        [Column("proveedor_id_Proveedor")]
        public int ProveedorIdProveedor { get; set; }

        [ForeignKey("ProveedorIdProveedor")]
        [InverseProperty("Productos")]
        public virtual Proveedor ProveedorIdProveedorNavigation { get; set; } = null!;
        [ForeignKey("UsuarioIdUsuario")]
        [InverseProperty("Productos")]
        public virtual Usuario UsuarioIdUsuarioNavigation { get; set; } = null!;
        [InverseProperty("ProductoIdProductoNavigation")]
        public virtual ICollection<DetalleProducto> DetalleProductos { get; set; }
        [InverseProperty("ProductoIdProductoNavigation")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
