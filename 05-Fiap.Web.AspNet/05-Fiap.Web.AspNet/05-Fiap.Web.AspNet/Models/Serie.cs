using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    [Table("TSerie")]
    public class Serie
    {
        [Column("Id"),HiddenInput]
        public int SerieId { get; set; }

        [Required, MaxLength(50)]
        public String Nome { get; set; }

        public Genero Tipo { get; set; }


        [Display(Name = "Data de Lancçamento"),DataType(DataType.Time),Required]
        public DateTime DataLancamento { get; set; }

        public int Temporadas { get; set; }

    }
}
