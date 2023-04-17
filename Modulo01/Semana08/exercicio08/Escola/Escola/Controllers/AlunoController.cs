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

    }
}
