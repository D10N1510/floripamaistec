using EscolaSemana10.Models;

namespace EscolaSemana10.Repositories.Interfaces
{
    public interface ITeacherRepository
    {
        public void Criar(Teacher x);
        public void Atualizar(Teacher x);
        public List<Teacher> Listar();
        public Teacher? ObterPorId(int id);
        public void Excluir(int id);
    }
}
