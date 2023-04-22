using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherService(ITeacherRepository x)
        {
            _repository = x;
        }
        public void Atualizar(Teacher x)
        {
            _repository.Atualizar(x);
        }

        public void Criar(Teacher x)
        {
            _repository.Criar(x);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public IEnumerable<Teacher> Listar()
        {
            return _repository.Listar();
        }

        public Teacher? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
