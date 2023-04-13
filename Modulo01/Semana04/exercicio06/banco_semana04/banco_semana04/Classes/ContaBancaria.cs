using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_semana04.Classes
{
    /* [M1S04] Ex 2 - Criação classe base ContaBancaria
     Defina uma classe chamada ContaBancaria com os seguintes atributos:

    numero - int;
    agencia - int;
    cliente - Cliente (classe criada no exercício 01);
    saldo - decimal - deve iniciar em 0;
    Todos os atributos precisam ser propriedades sendo o Get public porém o Set sendo protected.

    Ex: public decimal Saldo { get; protected set; }

    Crie também um construtor padrão recebendo todos os atributos como argumentos, exceto o saldo.

    Em seguida crie os seguintes métodos:

    Sacar() - saca um valor;
    Depositar() - deposita um valor;
    Transferir() - transfere um valor;
    ExibirSaldo() - exibe uma mensagem com o saldo atual;
    Observação: os métodos 01 ao 04 podem ser copiados diretamente do exercício da semana 03.
     */
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Clnte { get; protected set; }
        public decimal Saldo { get; protected set; }
               
        public ContaBancaria(int num,int agen,Cliente c)
        {
            Numero= num;
            Agencia= agen;
            Clnte= c;
            Saldo = 0;
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0)
                Console.WriteLine("O deposito deve ser maior que 0.");
            else
                Saldo = Saldo + monto;
        }

        public virtual void Sacar(decimal monto)
        {
            if (monto <= 0)
                Console.WriteLine("O saque deve ser maior que 0.");
            else if (monto > Saldo)
                Console.WriteLine("O saque não pode ser maior do que o saldo disponível.");
            else
            {
                Saldo = Saldo - monto;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("O saldo atual da conta é {0}",Saldo);
        }

       
        public virtual void Transferir(ContaBancaria contaDestino, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior do que 0.");
                return;
            }

            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            Saldo = Saldo - valor;
            contaDestino.Depositar(valor);

            Console.WriteLine($"\nValor de R$ {valor} transferido com sucesso.");
        }

        public void ExibirDados()
        {
            Console.WriteLine("\n*** Dados da Conta: ");
            Console.WriteLine("  Número:{0}\n  Agencia: {1}\n  Cliente:{2}\n  Saldo: {3}\n", Numero, Agencia, Clnte.Nome, Saldo);
        }
    }

}
