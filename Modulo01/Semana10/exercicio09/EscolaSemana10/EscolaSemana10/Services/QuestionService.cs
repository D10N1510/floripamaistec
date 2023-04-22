using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _repository;

        public QuestionService(IQuestionRepository x)
        {
            _repository = x;
        }
        public void Atualizar(Question x)
        {
            _repository.Atualizar(x);
        }

        public void Criar(Question x)
        {
            _repository.Criar(x);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public IEnumerable<Question> Listar()
        {
            return _repository.Listar();
        }

        public Question? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
