using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("pedidos")]
    [Index("ProductoIdProducto", Name = "fk_pedidos_Producto1_idx")]
    [Index("UsuarioIdUsuario", Name = "fk_pedidos_usuario1_idx")]
    public partial class Pedido
    {
        [Key]
        [Column("id_Pedidos")]
        public int IdPedidos { get; set; }
        [StringLength(100)]
        public string? Articulo { get; set; }
        [StringLength(100)]
        public string? Direccion { get; set; }
        [StringLength(200)]
        public string? Referencia { get; set; }
        [Column("usuario_id_Usuario")]
        public int UsuarioIdUsuario { get; set; }
        [Column("Producto_id_Producto")]
        public int ProductoIdProducto { get; set; }

        [ForeignKey("ProductoIdProducto")]
        [InverseProperty("Pedidos")]
        public virtual Producto ProductoIdProductoNavigation { get; set; } = null!;
        [ForeignKey("UsuarioIdUsuario")]
        [InverseProperty("Pedidos")]
        public virtual Usuario UsuarioIdUsuarioNavigation { get; set; } = null!;
    }
}
