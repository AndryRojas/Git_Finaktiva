using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Finaktiva_AndryRojas.Models
{
    public class Region
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRegion{ get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}