using EscolaSemana10.Models;
using EscolaSemana10.Repositories;
using EscolaSemana10.Repositories.Interfaces;
using EscolaSemana10.Services.Interfaces;

namespace EscolaSemana10.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public void Atualizar(Teacher x)
        {
            _teacherRepository.Atualizar(x);
        }

        public void Criar(Teacher x)
        {
            _teacherRepository.Criar(x);
        }

        public void Excluir(int id)
        {
            _teacherRepository.Excluir(id);
        }

        public IEnumerable<Teacher> Listar()
        {
            return _teacherRepository.Listar();
        }

        public Teacher? ObterPorId(int id)
        {
            return _teacherRepository.ObterPorId(id);
        }
    }
}
