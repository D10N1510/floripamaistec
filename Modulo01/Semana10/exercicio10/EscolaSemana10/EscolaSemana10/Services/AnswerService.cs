using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _repository;

        public AnswerService(IAnswerRepository x)
        {
            _repository = x;
        }
        public void Atualizar(Answer x)
        {
            _repository.Atualizar(x);
        }

        public void Criar(Answer x)
        {
            _repository.Criar(x);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public IEnumerable<Answer> Listar()
        {
            return _repository.Listar();
        }

        public Answer? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
