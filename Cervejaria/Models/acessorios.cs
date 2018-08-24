using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cervejaria.Models
{
    public class acessorios
    {
        [Key]
        public int Handle { get; set; }
        public String Acessorio { get; set; }
        public String Descricao { get; set; }
        public String Uso { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }

    }
}