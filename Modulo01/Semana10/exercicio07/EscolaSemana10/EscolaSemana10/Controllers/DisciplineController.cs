using EscolaSemana10.DTOs;
using EscolaSemana10.Models;
using EscolaSemana10.Services;
using EscolaSemana10.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EscolaSemana10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineService _service;


        public DisciplineController(IDisciplineService x)
        {
            _service = x;
        }

        [HttpPost]
        [Route("criar")]
        public ActionResult<Discipline> Criar(Discipline x)
        {
            _service.Criar(x);
            return CreatedAtAction(nameof(DisciplineController), new { id = x.Id }, x);
        }

        [HttpPut]
        [Route("atualizar/{id}")]
        public IActionResult Atualizar(int id, [FromBody] DisciplineAlterDTO xdto)
        {
            var x = _service.ObterPorId(id);

            if (x == null)
                return NotFound();

            x.TeacherId = xdto.TeacherId;
            x.DisciplineName = xdto.DisciplineName;

            return CreatedAtAction(nameof(DisciplineController.ListarPorId), new { id = x.Id }, x);
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
