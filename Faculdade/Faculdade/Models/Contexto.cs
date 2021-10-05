using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculdade.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Universidade> Universidades { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public Contexto( DbContextOptions<Contexto> opcoes ): base(opcoes)
        {

        }
    }
}
