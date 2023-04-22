using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository x)
        {
            _repository = x;
        }
        public void Atualizar(Student x)
        {
            _repository.Atualizar(x);
        }

        public void Criar(Student x)
        {
            _repository.Criar(x);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public IEnumerable<Student> Listar()
        {
            return _repository.Listar();
        }

        public Student? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
