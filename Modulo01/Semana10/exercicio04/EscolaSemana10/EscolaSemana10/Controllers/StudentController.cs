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
        private readonly IStudentService _studentService;


        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        [Route("criar")]
        public ActionResult<Student> Criar(Student student)
        {            
            _studentService.Criar(student);
            return CreatedAtAction(nameof(StudentController), new { id = student.Id }, student);
        }

        [HttpPut]
        [Route("atualizar/{id}")]
        public IActionResult Atualizar(int id, [FromBody] StudentAlterDTO StudentDto)
        {
            var student = _studentService.ObterPorId(id);

            if (student == null)
                return NotFound();

            student.UserId = StudentDto.UserId;
            student.Period = StudentDto.Period;
            student.RA = StudentDto.RA;

            return CreatedAtAction(nameof(StudentController.ListarPorId), new { id = student.Id }, student);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            var students = _studentService.Listar();
            return Ok(students);
        }

        [HttpGet]
        [Route("listarporid/{id}")]
        public IActionResult ListarPorId(int id)
        {
            var student = _studentService.ObterPorId(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            var s = _studentService.ObterPorId(id);
            if (s == null)
               return NotFound();

            _studentService.Excluir(id);

            return NoContent();
        }


    }
}
