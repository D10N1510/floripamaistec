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

        public void Atualizar(Student x)
        {
            _context.Students.Update(x);
            _context.SaveChanges();
        }

        public void Criar(Student x)
        {
            _context.Students.Add(x);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var x = ObterPorId(id);
            _context.Students.Remove(x);
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
