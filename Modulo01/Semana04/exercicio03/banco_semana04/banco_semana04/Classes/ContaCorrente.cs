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
    }
}
