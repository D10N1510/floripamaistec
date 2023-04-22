using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _repository;

        public QuizService(IQuizRepository x)
        {
            _repository = x;
        }
        public void Atualizar(Quiz x)
        {
            _repository.Atualizar(x);
        }

        public void Criar(Quiz x)
        {
            _repository.Criar(x);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public IEnumerable<Quiz> Listar()
        {
            return _repository.Listar();
        }

        public Quiz? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
