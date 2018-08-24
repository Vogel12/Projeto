using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cervejaria.Models
{
    public class insumos
    {
        [Key]
        public int Handle { get; set; }
        public String Produto { get; set; }
        public String Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
    }
}