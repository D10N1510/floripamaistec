using EscolaSemana10.Models;

namespace EscolaSemana10.Services.Interfaces
{
    public interface IQuestionService
    {
        public void Criar(Question x);
        public void Atualizar(Question x);
        public IEnumerable<Question> Listar();
        public Question? ObterPorId(int id);
        public void Excluir(int id);
    }
}
