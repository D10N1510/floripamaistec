using EscolaSemana10.Models;
using EscolaSemana10.Repositories.Interfaces;

namespace EscolaSemana10.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly EscolaContexto _context;

        public StudentRepository(EscolaContexto context)
        {
            _context = context;
        }

        public void Atualizar(Student s)
        {
            _context.Students.Update(s);
            _context.SaveChanges();
        }

        public void Criar(Student Student)
        {
            _context.Students.Add(Student);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var Student = ObterPorId(id);
            _context.Students.Remove(Student);
            _context.SaveChanges();
        }

        public List<Student> Listar()
        {
            return _context.Students.ToList();
        }

        public Student? ObterPorId(int id)
        {
            return _context.Students.FirstOrDefault(
                x => x.Id.Equals(id));
        }
    }
}
