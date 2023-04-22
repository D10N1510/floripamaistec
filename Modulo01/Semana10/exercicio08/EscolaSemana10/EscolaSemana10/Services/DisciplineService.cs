using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class DisciplineService : IDisciplineService
    {
        private readonly IDisciplineRepository _repository;

        public DisciplineService(IDisciplineRepository x)
        {
            _repository = x;
        }
        public void Atualizar(Discipline x)
        {
            _repository.Atualizar(x);
        }

        public void Criar(Discipline x)
        {
            _repository.Criar(x);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public IEnumerable<Discipline> Listar()
        {
            return _repository.Listar();
        }

        public Discipline? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
