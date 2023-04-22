using EscolaSemana10.Models;
using EscolaSemana10.Repositories.Interfaces;

namespace EscolaSemana10.Repositories
{
    public class DisciplineRepository : IDisciplineRepository
    {
        private readonly EscolaContexto _context;

        public DisciplineRepository(EscolaContexto context)
        {
            _context = context;
        }

        public void Atualizar(Discipline x)
        {
            _context.Disciplines.Update(x);
            _context.SaveChanges();
        }

        public void Criar(Discipline x)
        {
            _context.Disciplines.Add(x);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var x = ObterPorId(id);
            _context.Disciplines.Remove(x);
            _context.SaveChanges();
        }

        public List<Discipline> Listar()
        {
            return _context.Disciplines.ToList();
        }

        public Discipline? ObterPorId(int id)
        {
            return _context.Disciplines.FirstOrDefault(
                x => x.Id.Equals(id));
        }
    }
}
