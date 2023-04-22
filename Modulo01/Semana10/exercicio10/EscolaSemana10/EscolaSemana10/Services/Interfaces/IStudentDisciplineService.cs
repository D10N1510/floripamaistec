using EscolaSemana10.Models;

namespace EscolaSemana10.Services.Interfaces
{
    public interface IStudentDisciplineService
    {
        public void Criar(Student_Discipline x);
        public void Atualizar(Student_Discipline x);
        public IEnumerable<Student_Discipline> Listar();
        public Student_Discipline? ObterPorId(int id);
        public void Excluir(int id);
    }
}
