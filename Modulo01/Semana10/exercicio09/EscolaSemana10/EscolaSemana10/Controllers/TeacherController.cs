using EscolaSemana10.DTOs;
using EscolaSemana10.Models;
using EscolaSemana10.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EscolaSemana10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;


        public TeacherController(ITeacherService x)
        {
            _service = x;
        }

        [HttpPost]
        [Route("criar")]
        public ActionResult<Teacher> Criar(Teacher x)
        {
            _service.Criar(x);
            return CreatedAtAction(nameof(TeacherController), new { id = x.Id }, x);
        }

        [HttpPut]
        [Route("atualizar/{id}")]
        public IActionResult Atualizar(int id, [FromBody] TeacherAlterDTO xdto)
        {
            var x = _service.ObterPorId(id);

            if (x == null)
                return NotFound();

            x.UserId = xdto.UserId;
            x.Department = xdto.Department;

            return CreatedAtAction(nameof(TeacherController.ListarPorId), new { id = x.Id }, x);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            var xs = _service.Listar();
            return Ok(xs);
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
            var s = _service.ObterPorId(id);
            if (s == null)
               return NotFound();

            _service.Excluir(id);

            return NoContent();
        }


    }
}
