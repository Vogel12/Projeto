using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cervejaria.Models
{
    public class equipamentosContexto : DbContext
    {
        DbSet<equipamentos> Equipamentos { get; set; }

        public System.Data.Entity.DbSet<Cervejaria.Models.equipamentos> equipamentos { get; set; }
    }
}