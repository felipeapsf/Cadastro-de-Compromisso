using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using Projeto.Services.Models;

namespace Projeto.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompromissoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(CompromissoCadastroModel model,
            [FromServices] ICompromissoRepository repository,
            [FromServices] IMapper mapper)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var compromisso = mapper.Map<Compromisso>(model);
                    repository.Inserir(compromisso);

                    return Ok("Compromisso cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    return StatusCode(500, e.Message);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put(CompromissoEdicaoModel model,
            [FromServices] ICompromissoRepository repository,
            [FromServices] IMapper mapper
            )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var compromisso = mapper.Map<Compromisso>(model);
                    repository.Atualizar(compromisso);

                    return Ok("Compromisso atualizado com sucesso.");
                }
                catch (Exception e)
                {
                    return StatusCode(500, e.Message);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] ICompromissoRepository repository)
        {
            try
            {
                var compromisso = repository.ObterPorId(id);
                repository.Excluir(compromisso);

                return Ok("Compromisso excluido com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll(
            [FromServices] ICompromissoRepository repository,
            [FromServices] IMapper mapper
            )
        {
            try
            {
                var lista = mapper.Map<List<CompromissoConsultaModel>>
                    (repository.ObterTodos());

                return Ok(lista);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id,
            [FromServices] ICompromissoRepository repository,
            [FromServices] IMapper mapper)
        {
            try
            {
                var model = mapper.Map<CompromissoConsultaModel>
                    (repository.ObterPorId(id));

                return Ok(model);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
