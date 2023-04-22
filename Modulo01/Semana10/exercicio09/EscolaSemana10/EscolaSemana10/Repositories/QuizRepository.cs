using EscolaSemana10.Models;
using EscolaSemana10.Repositories.Interfaces;

namespace EscolaSemana10.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly EscolaContexto _context;

        public QuizRepository(EscolaContexto context)
        {
            _context = context;
        }

        public void Atualizar(Quiz x)
        {
            _context.Quizs.Update(x);
            _context.SaveChanges();
        }

        public void Criar(Quiz x)
        {
            _context.Quizs.Add(x);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var x = ObterPorId(id);
            _context.Quizs.Remove(x);
            _context.SaveChanges();
        }

        public List<Quiz> Listar()
        {
            return _context.Quizs.ToList();
        }

        public Quiz? ObterPorId(int id)
        {
            return _context.Quizs.FirstOrDefault(
                x => x.Id.Equals(id));
        }
    }
}
