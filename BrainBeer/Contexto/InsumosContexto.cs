using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrainBeer.Models
{
    public class Contextos : DbContext
    {
        public DbSet<Acessorios> acessorios { get; set; }
        public DbSet<Insumos> insumos { get; set; }

        //public System.Data.Entity.DbSet<BrainBeer.Models.Insumos> Insumos { get; set; }

    }
}