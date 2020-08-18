using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Finaktiva_AndryRojas.Models
{
    public class DbContenido:DbContext
    {
        public DbContenido()
            :base("DdConectar")
            {

            }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}