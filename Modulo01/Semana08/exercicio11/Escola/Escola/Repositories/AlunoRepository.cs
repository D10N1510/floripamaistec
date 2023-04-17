using System.Globalization;
using System.Text;
using Escola.DTOs;
using Escola.Models;

namespace Escola.Repositories
{
    public class AlunoRepository
    {
        private static List<AlunoModel> listaAlunos = 
            new List<AlunoModel>(){         
                new AlunoModel { Id = 1, Nome = "Jose Perez"},
                new AlunoModel { Id = 2, Nome = "Bruno Sales"},
                new AlunoModel { Id = 3, Nome = "Mauricio da Silva"},
                new AlunoModel { Id = 4, Nome = "Silvia teles"},
                new AlunoModel { Id = 5, Nome = "Tatiana Seabra"}
            };


        public List<AlunoModel> ListarAlunos(string nome)
        {
            if (string.IsNullOrEmpty(nome))                       
                return listaAlunos;
            
            return listaAlunos.Where(
                z => z.Nome.ToLower().RemoverAcentos().Contains(nome.ToLower().RemoverAcentos())
                ).OrderBy(a => a.Id).ToList();
        }

        public AlunoModel ObterAluno(int idAluno)
        {
            return listaAlunos.FirstOrDefault(a => a.Id == idAluno);
        }

        public AlunoModel CriarAluno(AlunoDTO dto)
        {
            var a = new AlunoModel();
            a.Id = CriarIdAluno();
            a.Nome = dto.Nome;
            listaAlunos.Add(a);
            return a;
        }
        private int CriarIdAluno()
        {
            return listaAlunos.Last().Id + 1;
        }

        public void ExcluirAluno(int idAluno)
        {
            var a = listaAlunos.FirstOrDefault(a => a.Id == idAluno);
            if (a != null)
                listaAlunos.Remove(a);
        }

    }

    public static class StringExtension
    {
        public static string RemoverAcentos(this string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }
    }


}
