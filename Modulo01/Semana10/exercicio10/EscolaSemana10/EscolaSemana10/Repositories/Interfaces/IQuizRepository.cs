using EscolaSemana10.Models;

namespace EscolaSemana10.Repositories.Interfaces
{
    public interface IQuizRepository
    {
        public void Criar(Quiz x);
        public void Atualizar(Quiz x);
        public List<Quiz> Listar();
        public Quiz? ObterPorId(int id);
        public void Excluir(int id);
    }
}
