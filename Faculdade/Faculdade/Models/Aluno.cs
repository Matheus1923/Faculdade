using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Faculdade.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        [Column("idaluno")]
        [Required( ErrorMessage = "O campo é obrigatório")]

        public Int32 IdAluno { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 30")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 30")]
        [Column("email")]

        public string Email { get; set; }

        [Column("iduniversidade")]
        [Required ( ErrorMessage = "O campo é obrigatório")]

        public int IdUniversidade { get; set; }
    }
}
