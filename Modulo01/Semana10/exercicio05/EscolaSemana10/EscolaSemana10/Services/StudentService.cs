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
        public void Atualizar(Student x)
        {
            _studentRepository.Atualizar(x);
        }

        public void Criar(Student x)
        {
            _studentRepository.Criar(x);
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
