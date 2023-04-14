using System;
using System.IO;

namespace CriarArquivoComTratamentoExcecoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileInfo arquivo = null;         
            try
            {
                Console.Write("Digite o nome do arquivo para criá-lo: ");
                string nomeArquivo = Console.ReadLine();
                arquivo = new FileInfo(nomeArquivo);

                using (StreamWriter gravadorTexto = File.AppendText(nomeArquivo+".txt"))
                {
                    gravadorTexto.WriteLine("Texto de dentro do arquivo.");
                }

                /* 
                 * Adicionei a extensao do formato .txt para criar arquivos de texto
                 * O arquivo é criado em /bin/Debug/net7.0
                 */
            }
            catch (System.ArgumentException e)
            {
                Console.WriteLine("Ocorreu o erro: {0}.\n\nDigite um nome para o arquivo", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu o erro: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Encerrando programa... \n"); 
                arquivo = null;
            }

        }
    }
}