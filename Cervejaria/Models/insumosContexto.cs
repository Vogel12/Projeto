using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cervejaria.Models
{
    public class insumosContexto : DbContext
    {
        DbSet<insumos> Insumos { get; set; }

        public System.Data.Entity.DbSet<Cervejaria.Models.insumos> insumos { get; set; }
    }
}