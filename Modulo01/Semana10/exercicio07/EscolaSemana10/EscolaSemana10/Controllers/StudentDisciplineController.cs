using EscolaSemana10.DTOs;
using EscolaSemana10.Models;
using EscolaSemana10.Services;
using EscolaSemana10.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EscolaSemana10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentDisciplineController : ControllerBase
    {
        private readonly IStudentDisciplineService _service;


        public StudentDisciplineController(IStudentDisciplineService x)
        {
            _service = x;
        }

        [HttpPost]
        [Route("criar")]
        public ActionResult<Student_Discipline> Criar(Student_Discipline x)
        {
            _service.Criar(x);
            return CreatedAtAction(nameof(StudentDisciplineController), new { id = x.Id }, x);
        }

        [HttpPut]
        [Route("atualizar/{id}")]
        public IActionResult Atualizar(int id, [FromBody] StudentDisciplineAlterDTO xdto)
        {
            var x = _service.ObterPorId(id);

            if (x == null)
                return NotFound();

            x.DisciplineId = xdto.DisciplineId;
            x.StudentId = xdto.StudentId;

            return CreatedAtAction(nameof(StudentDisciplineController.ListarPorId), new { id = x.Id }, x);
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
