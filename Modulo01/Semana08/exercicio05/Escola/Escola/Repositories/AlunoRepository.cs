using Escola.Models;

namespace Escola.Repositories
{
    public class AlunoRepository
    {
        private static List<AlunoModel> lista = 
            new List<AlunoModel>(){         
                new AlunoModel { Id = 1, Nome = "Jose Perez"},
                new AlunoModel { Id = 2, Nome = "Bruno Sales"},
                new AlunoModel { Id = 3, Nome = "Mauricio da Silva"},
                new AlunoModel { Id = 4, Nome = "Silvia teles"},
                new AlunoModel { Id = 5, Nome = "Tatiana Seabra"}
            };

    }
}
