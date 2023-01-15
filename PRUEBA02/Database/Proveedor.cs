using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PRUEBA02.Database
{
    [Table("proveedor")]
    public partial class Proveedor
    {
        public Proveedor()
        {
            Productos = new HashSet<Producto>();
        }

        [Key]
        [Column("id_Proveedor")]
        public int IdProveedor { get; set; }
        [Column("proveedor")]
        [StringLength(20)]
        public string? Proveedor1 { get; set; }
        [StringLength(50)]
        public string? Tipo { get; set; }
        [StringLength(100)]
        public string? Descripcion { get; set; }

        [InverseProperty("ProveedorIdProveedorNavigation")]
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
