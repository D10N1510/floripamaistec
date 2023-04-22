using EscolaSemana10.DTOs;
using EscolaSemana10.Models;
using EscolaSemana10.Services;
using EscolaSemana10.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EscolaSemana10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _service;


        public AnswerController(IAnswerService x)
        {
            _service = x;
        }

        [HttpPost]
        [Route("criar")]
        public ActionResult<Answer> Criar(Answer x)
        {
            _service.Criar(x);
            return CreatedAtAction(nameof(AnswerController), new { id = x.Id }, x);
        }

        [HttpPut]
        [Route("atualizar/{id}")]
        public IActionResult Atualizar(int id, [FromBody] AnswerAlterDTO xdto)
        {
            var x = _service.ObterPorId(id);

            if (x == null)
                return NotFound();

            x.AnswerText = xdto.AnswerText;
            x.StudentId = xdto.StudentId;
            x.QuestionId = xdto.QuestionId;
            x.Image=xdto.Image;
            x.Observation= xdto.Observation;
            x.Score= xdto.Score;

            return CreatedAtAction(nameof(AnswerController.ListarPorId), new { id = x.Id }, x);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            var x = _service.Listar();
            return Ok(x);
        }

        [HttpGet]
        [Route("listarporid/{id}")]
        public IActionResult ListarPorId(int id)
        {
            var x = _service.ObterPorId(id);

            if (x == null)
                return NotFound();

            return Ok(x);
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            var x = _service.ObterPorId(id);
            if (x == null)
               return NotFound();

            _service.Excluir(id);

            return NoContent();
        }


    }
}
