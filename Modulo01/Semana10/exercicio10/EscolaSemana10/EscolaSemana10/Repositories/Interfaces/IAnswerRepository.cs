using EscolaSemana10.Models;

namespace EscolaSemana10.Repositories.Interfaces
{
    public interface IAnswerRepository
    {
        public void Criar(Answer x);
        public void Atualizar(Answer x);
        public List<Answer> Listar();
        public Answer? ObterPorId(int id);
        public void Excluir(int id);
    }
}
