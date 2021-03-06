﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Finaktiva_AndryRojas.Models
{
    public class Municipio
    {         
               
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodMunicipio { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public List<Region> Regiones { get; set; }
    }
}