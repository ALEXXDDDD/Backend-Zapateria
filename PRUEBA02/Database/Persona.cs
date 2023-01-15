using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("persona")]
    [Index("GeneroIdGenero", Name = "fk_persona_Genero1_idx")]
    public partial class Persona
    {
        public Persona()
        {
            Cargos = new HashSet<Cargo>();
            Usuarios = new HashSet<Usuario>();
        }

        [Key]
        [Column("id_Persona")]
        public int IdPersona { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; }
        [StringLength(50)]
        public string? Apellidos { get; set; }
        public int? Telefono { get; set; }
        [Column("Genero_id_Genero")]
        public int GeneroIdGenero { get; set; }

        [ForeignKey("GeneroIdGenero")]
        [InverseProperty("Personas")]
        public virtual Genero GeneroIdGeneroNavigation { get; set; } = null!;
        [InverseProperty("PersonaIdPersonaNavigation")]
        public virtual ICollection<Cargo> Cargos { get; set; }
        [InverseProperty("PersonaIdPersonaNavigation")]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
