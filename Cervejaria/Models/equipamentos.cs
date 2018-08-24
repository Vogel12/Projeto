using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cervejaria.Models
{
    public class equipamentos
    {
        [Key]
        public int Handle { get; set; }
        public String Equipamento { get; set; }
        public String Descricao { get; set; }
        public int Quantidade { get; set; }
        public String Uso { get; set; }
        public DateTime Data { get; set; }
        
    }
}