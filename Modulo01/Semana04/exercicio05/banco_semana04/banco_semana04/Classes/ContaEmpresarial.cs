using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banco_semana04.Classes.@enum;

namespace banco_semana04.Classes
{
    /*
     Na classe ContaEmpresarial defina os seguintes atributos:

    LimiteEmprestimo - decimal;
    TaxaJuros - decimal;
    PossuiEmprestimo - bool;
    ValorUsado - decimal;
    CNPJ - string;
    Os atributos precisam ser propriedades sendo o Get public porém o Set sendo private.

    Ex: public decimal TaxaJuros { get; private set; }

    Altere o construtor padrão recebendo os atributos novos também como argumentos, exceto PossuiEmprestimo.
     */
    public class ContaEmpresarial : ContaBancaria
    {
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public decimal ValorUsado { get; private set; }
        public string CNPJ { get; private set; }

        public ContaEmpresarial(int num, int agen, Cliente c,decimal limitEmp,decimal taxaJur,string cnpj) : base(num, agen, c)
        {
            LimiteEmprestimo= limitEmp;
            TaxaJuros= taxaJur;
            CNPJ= cnpj;
            ValorUsado = 0; 
            PossuiEmprestimo = false;
            
            if (c.TipoPessoa != ETipoPessoa.JURIDICA)
            {
                throw new ArgumentException("Cliente deve ser pessoa jurídica!\n");
            }
        }


        /* [M1S04] Ex 5 - Criação de novos métodos na classe ContaEmpresarial
         Na classe ContaEmpresarial defina os seguintes métodos:

            FazerEmprestimo():
            realiza uma transação de empréstimo recebendo como parâmetro o valor do empréstimo.
            O valor não pode ser maior do que o definido no atributo LimiteEmprestimo.
            O valor recebido deve ser adicionado ao saldo.
            Só é permitido um empréstimo por vez. Para realização de um novo deve ser feito o pagamento do anterior;
            PagarEmprestimo():
            realiza o pagamento do valor pegue por empréstimo adicionado a taxa de juros.
            O empréstimo deve ser pago em valor integral.
            O valor pago deve ser retirado do saldo;
            a propriedade PossuiEmprestimo deve ser marcada como false;
         */

        public void FazerEmprestimo(decimal valor)
        {
            if (valor<=0){
                Console.WriteLine("O valor deve ser maior que 0.");
                return;
            }

            if (PossuiEmprestimo==true){
                Console.WriteLine("Cliente já possui um empréstimo.");
                return;
            }

            if (valor>LimiteEmprestimo){
                Console.WriteLine("O valor é maior que o seu limite de empréstimo.");
                return;
            }

            PossuiEmprestimo = true;
            Depositar(valor);
            ValorUsado = valor;
            Console.WriteLine("Empréstimo realizado com sucesso no valor de R$ {0}.",valor);
        }

        public void PagarEmprestimo()
        {
            decimal totalPagar= ValorUsado+(ValorUsado * (TaxaJuros / 100));

            if (totalPagar > Saldo){
                Console.WriteLine("Cliente não tem saldo suficiente para pagar o empréstimo.");
                return;
            }

            Sacar(totalPagar);

            PossuiEmprestimo = false;
            ValorUsado = 0;
            
            Console.WriteLine("Empréstimo no valor total de R$ {0} pago com sucesso.", totalPagar);
            Console.WriteLine("A taxa cobrada é: {0}%", TaxaJuros);
        }

    }
}
