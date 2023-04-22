using EscolaSemana10.Models;
using EscolaSemana10.Repositories.Interfaces;

namespace EscolaSemana10.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly EscolaContexto _context;

        public AnswerRepository(EscolaContexto context)
        {
            _context = context;
        }

        public void Atualizar(Answer x)
        {
            _context.Answers.Update(x);
            _context.SaveChanges();
        }

        public void Criar(Answer x)
        {
            _context.Answers.Add(x);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var x = ObterPorId(id);
            _context.Answers.Remove(x);
            _context.SaveChanges();
        }

        public List<Answer> Listar()
        {
            return _context.Answers.ToList();
        }

        public Answer? ObterPorId(int id)
        {
            return _context.Answers.FirstOrDefault(
                x => x.Id.Equals(id));
        }
    }
}
