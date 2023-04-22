using EscolaSemana10.Models;

namespace EscolaSemana10.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        public void Criar(Question x);
        public void Atualizar(Question x);
        public List<Question> Listar();
        public Question? ObterPorId(int id);
        public void Excluir(int id);
    }
}
