using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Classes.Enum;

namespace Banco.Classes
{
    public class ContaBancaria
    {
        public int numero;
        public int agencia;
        public string nomeDoTitular = "";
        public decimal saldo = 0;
        public ETipoConta tipoConta;

        /* M01S03 - [M1S02] Ex 2 - Criação de construtor da classe ContaBancaria
         Descrição:

        Na semana passada (semana 2) criamos uma classe chamada ContaBancaria. 
        Nela colocarmos os seus atributos todos públicos, e criamos alguns métodos para Depositar, 
        Sacar e Exibir o saldo. Agora, crie um construtor para receber os valores dos atributos na 
        instanciação da classe. O construtor deve receber:

        nome do titular - string;
        agencia - int;
        numero - int;
        tipo de conta - Enum;
        */
        public ContaBancaria(string nome, int ag, int num, ETipoConta tconta)
        {
            nomeDoTitular= nome;
            agencia= ag;
            numero= num;
            tipoConta= tconta;
        }

        public void Deposito(decimal monto)
        {
            if (monto <= 0)
                Console.WriteLine("O deposito deve ser maior que 0.");
            else
                saldo = saldo + monto;
        }

        public void Saque(decimal monto)
        {
            if (monto <= 0)
                Console.WriteLine("O saque deve ser maior que 0.");
            else if (monto > saldo)
                Console.WriteLine("O saque não pode ser maior do que o saldo disponível.");
            else
            {
                saldo = saldo - monto;
            }
        }

        public void ExibeSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é {saldo}");
        }

        public void ImprimeDados()
        {
            Console.WriteLine("\n*** Dados da Conta: ");
            Console.WriteLine("  Nome:{0}\n  Agencia: {1}\n  Número:{2}\n  Tipo: {3}\n",nomeDoTitular,agencia,numero,tipoConta);
        }
    }
}
