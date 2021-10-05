using Faculdade.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Faculdade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversidadeController : ControllerBase
    {

        public Contexto Contexto { get; set; }

        public UniversidadeController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }
        // GET: api/<UniversidadeController>
        [HttpGet]
        public List<Universidade> Get()
        {
            return Contexto.Universidades.ToList();
        }

        // GET api/<UniversidadeController>/5
        [HttpGet("{id}")]
        public Universidade Get(int id)
        {
            return Contexto.Universidades.First(e => e.IdUniversidade == id);
        }

        // POST api/<UniversidadeController>
        [HttpGet("idUniversidade/{idUniversidade}")]
        public List<Universidade> filtrar(int id)
        {
            return Contexto.Universidades.Where(e => e.IdUniversidade == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Universidade>> Create(Universidade Universidade)
        {
            Universidade.IdUniversidade = 0;
            Contexto.Universidades.Add(Universidade);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Universidade.IdUniversidade, Universidade });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Universidade>> Update(Universidade Universidade)
        {
            Contexto.Universidades.Update(Universidade);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Universidade.IdUniversidade, Universidade });
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Universidade>> Remove(Universidade Universidade)
        {
            Contexto.Universidades.Remove(Universidade);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Universidade.IdUniversidade, Universidade });
        }
    }
}
