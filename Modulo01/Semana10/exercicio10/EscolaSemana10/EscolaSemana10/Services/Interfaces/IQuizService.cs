using EscolaSemana10.Models;

namespace EscolaSemana10.Services.Interfaces
{
    public interface IQuizService
    {
        public void Criar(Quiz x);
        public void Atualizar(Quiz x);
        public IEnumerable<Quiz> Listar();
        public Quiz? ObterPorId(int id);
        public void Excluir(int id);
    }
}
