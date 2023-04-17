using Escola.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers
{
    [ApiController]
    public class AlunoController: ControllerBase
    {
        [HttpGet]
        [Route("listarAlunos")]
        public IActionResult Listar([FromQuery] string? nome)
        {
            var repositorio = new AlunoRepository();
            var alunos = repositorio.ListarAlunos(nome);

            return Ok(alunos);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            if (id <= 0)
               return BadRequest("Id deve ser maior que 0");
            
            var repositorio = new AlunoRepository();
            var aluno = repositorio.ObterAluno(id);

            if (aluno == null)
                return NotFound();
            
            return Ok(aluno);
        }


    }
}
