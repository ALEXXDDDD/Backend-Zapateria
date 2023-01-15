using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("usuario")]
    [Index("PersonaIdPersona", Name = "fk_usuario_persona_idx")]
    public partial class Usuario
    {
        public Usuario()
        {
            Pedidos = new HashSet<Pedido>();
            Productos = new HashSet<Producto>();
            Venta = new HashSet<Venta>();
        }

        [Key]
        [Column("id_Usuario")]
        public int IdUsuario { get; set; }
        [Column("Usuario")]
        [StringLength(20)]
        public string? Usuario1 { get; set; }
        [StringLength(50)]
        public string? Correo { get; set; }
        [StringLength(100)]
        public string? Clave { get; set; }
        [Column("persona_id_Persona")]
        public int PersonaIdPersona { get; set; }

        [ForeignKey("PersonaIdPersona")]
        [InverseProperty("Usuarios")]
        public virtual Persona PersonaIdPersonaNavigation { get; set; } = null!;
        [InverseProperty("UsuarioIdUsuarioNavigation")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
        [InverseProperty("UsuarioIdUsuarioNavigation")]
        public virtual ICollection<Producto> Productos { get; set; }
        [InverseProperty("UsuarioIdUsuarioNavigation")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
