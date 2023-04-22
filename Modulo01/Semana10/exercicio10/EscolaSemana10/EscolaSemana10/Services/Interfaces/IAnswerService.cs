using EscolaSemana10.Models;

namespace EscolaSemana10.Services.Interfaces
{
    public interface IAnswerService
    {
        public void Criar(Answer x);
        public void Atualizar(Answer x);
        public IEnumerable<Answer> Listar();
        public Answer? ObterPorId(int id);
        public void Excluir(int id);
    }
}
