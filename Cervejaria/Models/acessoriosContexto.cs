using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cervejaria.Models
{
    public class acessoriosContexto : DbContext
    {
        DbSet<acessorios> Acessorios { get; set; }

        public System.Data.Entity.DbSet<Cervejaria.Models.acessorios> acessorios { get; set; }
    }
}