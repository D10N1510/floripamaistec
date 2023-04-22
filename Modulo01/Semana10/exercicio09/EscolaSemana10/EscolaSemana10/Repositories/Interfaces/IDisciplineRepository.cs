using EscolaSemana10.Models;

namespace EscolaSemana10.Repositories.Interfaces
{
    public interface IDisciplineRepository
    {
        public void Criar(Discipline x);
        public void Atualizar(Discipline x);
        public List<Discipline> Listar();
        public Discipline? ObterPorId(int id);
        public void Excluir(int id);
    }
}
