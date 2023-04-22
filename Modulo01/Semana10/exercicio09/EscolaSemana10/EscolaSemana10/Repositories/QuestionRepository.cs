using EscolaSemana10.Models;
using EscolaSemana10.Repositories.Interfaces;

namespace EscolaSemana10.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly EscolaContexto _context;

        public QuestionRepository(EscolaContexto context)
        {
            _context = context;
        }

        public void Atualizar(Question x)
        {
            _context.Questions.Update(x);
            _context.SaveChanges();
        }

        public void Criar(Question x)
        {
            _context.Questions.Add(x);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var x = ObterPorId(id);
            _context.Questions.Remove(x);
            _context.SaveChanges();
        }

        public List<Question> Listar()
        {
            return _context.Questions.ToList();
        }

        public Question? ObterPorId(int id)
        {
            return _context.Questions.FirstOrDefault(
                x => x.Id.Equals(id));
        }
    }
}
