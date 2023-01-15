using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("genero")]
    public partial class Genero
    {
        public Genero()
        {
            Personas = new HashSet<Persona>();
        }

        [Key]
        [Column("id_Genero")]
        public int IdGenero { get; set; }
        [Column("sexo")]
        [StringLength(45)]
        public string? Sexo { get; set; }
        [Column("nacionalidad")]
        [StringLength(45)]
        public string? Nacionalidad { get; set; }

        [InverseProperty("GeneroIdGeneroNavigation")]
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
