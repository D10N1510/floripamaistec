using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Atualizar(Student s)
        {
            _studentRepository.Atualizar(s);
        }

        public void Criar(Student s)
        {
            _studentRepository.Criar(s);
        }

        public void Excluir(int id)
        {
            _studentRepository.Excluir(id);
        }

        public IEnumerable<Student> Listar()
        {
            return _studentRepository.Listar();
        }

        public Student? ObterPorId(int id)
        {
            return _studentRepository.ObterPorId(id);
        }
    }
}
