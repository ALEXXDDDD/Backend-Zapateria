using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("cargo")]
    [Index("PersonaIdPersona", Name = "fk_Cargo_persona1_idx")]
    public partial class Cargo
    {
        [Key]
        [Column("id_Cargo")]
        public int IdCargo { get; set; }
        [Column("code")]
        [StringLength(20)]
        public string? Code { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string? Descripcion { get; set; }
        [Column("detalle")]
        [StringLength(100)]
        public string? Detalle { get; set; }
        [Column("persona_id_Persona")]
        public int PersonaIdPersona { get; set; }

        [ForeignKey("PersonaIdPersona")]
        [InverseProperty("Cargos")]
        public virtual Persona PersonaIdPersonaNavigation { get; set; } = null!;
    }
}
