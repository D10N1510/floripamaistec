using EscolaSemana10.Models;

namespace EscolaSemana10.Services.Interfaces
{
    public interface IStudentService
    {
        public void Criar(Student s);
        public void Atualizar(Student s);
        public IEnumerable<Student> Listar();
        public Student? ObterPorId(int id);
        public void Excluir(int id);
    }
}
