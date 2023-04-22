using EscolaSemana10.Models;
using EscolaSemana10.Repositories.Interfaces;

namespace EscolaSemana10.Repositories
{
    public class StudentDisciplineRepository : IStudentDisciplineRepository
    {
        private readonly EscolaContexto _context;

        public StudentDisciplineRepository(EscolaContexto context)
        {
            _context = context;
        }

        public void Atualizar(Student_Discipline x)
        {
            _context.Student_Disciplines.Update(x);
            _context.SaveChanges();
        }

        public void Criar(Student_Discipline x)
        {
            _context.Student_Disciplines.Add(x);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var x = ObterPorId(id);
            _context.Student_Disciplines.Remove(x);
            _context.SaveChanges();
        }

        public List<Student_Discipline> Listar()
        {
            return _context.Student_Disciplines.ToList();
        }

        public Student_Discipline? ObterPorId(int id)
        {
            return _context.Student_Disciplines.FirstOrDefault(
                x => x.Id.Equals(id));
        }
    }
}
