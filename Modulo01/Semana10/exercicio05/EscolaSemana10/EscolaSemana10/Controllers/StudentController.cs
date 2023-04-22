using EscolaSemana10.DTOs;
using EscolaSemana10.Models;
using EscolaSemana10.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EscolaSemana10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;


        public StudentController(IStudentService x)
        {
            _service = x;
        }

        [HttpPost]
        [Route("criar")]
        public ActionResult<Student> Criar(Student x)
        {
            _service.Criar(x);
            return CreatedAtAction(nameof(StudentController), new { id = x.Id }, x);
        }

        [HttpPut]
        [Route("atualizar/{id}")]
        public IActionResult Atualizar(int id, [FromBody] StudentAlterDTO xdto)
        {
            var x = _service.ObterPorId(id);

            if (x == null)
                return NotFound();

            x.UserId = xdto.UserId;
            x.Period = xdto.Period;
            x.RA = xdto.RA;

            return CreatedAtAction(nameof(StudentController.ListarPorId), new { id = x.Id }, x);
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
