using EscolaSemana10.Models;

namespace EscolaSemana10.Services.Interfaces
{
    public interface IDisciplineService
    {
        public void Criar(Discipline x);
        public void Atualizar(Discipline x);
        public IEnumerable<Discipline> Listar();
        public Discipline? ObterPorId(int id);
        public void Excluir(int id);
    }
}
