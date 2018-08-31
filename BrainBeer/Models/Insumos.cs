using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrainBeer.Models
{
    public class Insumos
    {
        [Key]
        public int Handle { get; set; }
        public String Produto { get; set; }
        public String Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTimeOffset DataCompra { get; set; }
    }
}