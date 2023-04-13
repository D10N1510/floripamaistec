using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banco_semana04.Classes.@enum;

namespace banco_semana04.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int num, int agen, Cliente c) : base(num, agen, c)
        {
            if (c.TipoPessoa != ETipoPessoa.FISICA)
            {
                throw new ArgumentException("Cliente deve ser pessoa física!\n");
            }

        }
        /* [M1S04] Ex 6 - Sobrescrita métodos na classe ContaCorrente, ContaPoupanca e ContaEmpresarial
         Nas classes ContaCorrente e ContaPoupanca sobrescreva os seguintes métodos:
        Sacar():
        Classe ContaCorrente - deve ser cobrada uma taxa de R$ 0,50 por cada saque;
        Classe ContaPoupanca - deve ser cobrada uma taxa de R$ 0,10 por cada saque;
        Classe ContaEmpresarial - deve ser cobrada uma taxa de R$ 1,00 por cada saque;
        Transferir():
        Classe ContaCorrente - deve ser cobrada uma taxa de R$ 0,25 por cada transferência;
        Classe ContaPoupanca - deve ser cobrada uma taxa de R$ 0,05 por cada transferência;
        Classe ContaEmpresarial - deve ser cobrada uma taxa de R$ 0,50 por cada transferência;
         */
        public override void Sacar(decimal valor)
        {
            valor = valor + 0.50M;
            base.Sacar(valor);
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor = valor + 0.25M;
            base.Transferir(conta, valor);
        }


    }
}
