using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banco_semana04.Classes.@enum;

namespace banco_semana04.Classes
{
    /* [M1S04] Ex 1 - Criação de Classe Cliente
     Defina uma classe chamada Cliente com os seguintes atributos:

    nome - string;
    nascimento - Datetime;
    profissao - string;
    estadoCivil - string (você pode criar também um Enum caso prefira);
    tipoPessoa - enum (valores possíveis: FISICA, JURIDICA);
    Todos os atributos precisam ser propriedades sendo o Get public porém o Set sendo private.

    Ex: public string Nome { get; private set; }

    Crie também um construtor padrão recebendo todos os atributos como argumentos.
     */
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }
        public ETipoPessoa TipoPessoa { get; private set; }

        public Cliente(string nome, DateTime datnasc, string prof,string estadoc, ETipoPessoa tpessoa)
        {
            Nome= nome;
            Nascimento= datnasc;
            Profissao= prof;
            EstadoCivil= estadoc;
            TipoPessoa = tpessoa;
        }



        public void ExibeDados()
        {
            Console.WriteLine("\n*** Dados do Cliente:");
            Console.WriteLine("  Nome:{0}\n  Data Nascimento: {1}\n  Profissão: {2}\n  EstadoCivil: {3}\n  Tipo Cliente: {4}",
                Nome,Nascimento, Profissao,EstadoCivil,TipoPessoa);
        }

    }
}
