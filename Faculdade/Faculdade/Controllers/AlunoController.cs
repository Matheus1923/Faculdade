using Faculdade.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculdade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public AlunoController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Aluno> Get()
        {
            return Contexto.Alunos.ToList();
        }


        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return Contexto.Alunos.First(e => e.IdAluno == id);
        }


        [HttpGet("idAluno/{idAluno}")]
        public List<Aluno> filtrar(int id)
        {
            return Contexto.Alunos.Where(e => e.IdAluno == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Aluno>> Create(Aluno Aluno)
        {
            Aluno.IdAluno = 0;
            Contexto.Alunos.Add(Aluno);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Aluno.IdAluno, Aluno });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Aluno>> Update(Aluno Aluno)
        {
            Contexto.Alunos.Update(Aluno);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Aluno.IdAluno, Aluno });
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Aluno>> Remove(Aluno Aluno)
        {
            Contexto.Alunos.Remove(Aluno);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Aluno.IdAluno, Aluno });
        }
    }
}
