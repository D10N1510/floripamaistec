using EscolaSemana10.Models;

namespace EscolaSemana10.Repositories.Interfaces
{
    public interface IStudentDisciplineRepository
    {
        public void Criar(Student_Discipline x);
        public void Atualizar(Student_Discipline x);
        public List<Student_Discipline> Listar();
        public Student_Discipline? ObterPorId(int id);
        public void Excluir(int id);
    }
}
