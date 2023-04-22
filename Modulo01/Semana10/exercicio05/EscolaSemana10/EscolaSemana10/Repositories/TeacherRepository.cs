using EscolaSemana10.Models;
using EscolaSemana10.Repositories.Interfaces;

namespace EscolaSemana10.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly EscolaContexto _context;

        public TeacherRepository(EscolaContexto context)
        {
            _context = context;
        }

        public void Atualizar(Teacher x)
        {
            _context.Teachers.Update(x);
            _context.SaveChanges();
        }

        public void Criar(Teacher x)
        {
            _context.Teachers.Add(x);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var x = ObterPorId(id);
            _context.Teachers.Remove(x);
            _context.SaveChanges();
        }

        public List<Teacher> Listar()
        {
            return _context.Teachers.ToList();
        }

        public Teacher? ObterPorId(int id)
        {
            return _context.Teachers.FirstOrDefault(
                x => x.Id.Equals(id));
        }
    }
}
