using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class StudentDisciplineService : IStudentDisciplineService
    {
        private readonly IStudentDisciplineRepository _repository;

        public StudentDisciplineService(IStudentDisciplineRepository x)
        {
            _repository = x;
        }
        public void Atualizar(Student_Discipline x)
        {
            _repository.Atualizar(x);
        }

        public void Criar(Student_Discipline x)
        {
            _repository.Criar(x);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public IEnumerable<Student_Discipline> Listar()
        {
            return _repository.Listar();
        }

        public Student_Discipline? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
