using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    public class Serie
    {
        public String Nome { get; set; }

        public Genero Tipo { get; set; }


        [Display(Name = "Data de Lancçamento")]
        public DateTime DataLancamento { get; set; }

        public int Temporadas{ get; set; }

    }
}
