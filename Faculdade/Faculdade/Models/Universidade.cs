using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Faculdade.Models
{
    [Table("Universidade")]
    public class Universidade
    {
        [Key]
        [Column("iduniversidade")]
        [Required (ErrorMessage = "O campo é obrigatório")]

        public Int32 IdUniversidade { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser entre 10 á 30")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve entre 10 á 30")]
        [Column("endereco")]

        public string Endereco { get; set; }
    }
}
