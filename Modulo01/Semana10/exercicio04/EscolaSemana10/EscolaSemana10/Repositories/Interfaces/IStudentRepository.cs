using EscolaSemana10.Models;

namespace EscolaSemana10.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        public void Criar(Student Student);
        public void Atualizar(Student Student);
        public List<Student> Listar();
        public Student? ObterPorId(int id);
        public void Excluir(int id);
    }
}
