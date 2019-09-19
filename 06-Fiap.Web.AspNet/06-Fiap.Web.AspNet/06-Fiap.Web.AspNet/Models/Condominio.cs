using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    [Table("T_Condominio")]
    public class Condominio
    {
        [Column("Id")]
        public int CondominioId { get; set; }


        [Column("nm_Condominio"), Required]
        public string Nome { get; set; }

        [Column("num_Blocos")]
        public int Blocos { get; set; }

        [Column("bol_ativo")]
        public bool Ativo { get; set; }

        [Column("ds_tipo")]
        public Tipo Tipo { get; set; }

    }
}
