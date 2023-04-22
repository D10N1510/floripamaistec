using EscolaSemana10.Models;

namespace EscolaSemana10.Services.Interfaces
{
    public interface ITeacherService
    {
        public void Criar(Teacher x);
        public void Atualizar(Teacher x);
        public IEnumerable<Teacher> Listar();
        public Teacher? ObterPorId(int id);
        public void Excluir(int id);
    }
}
