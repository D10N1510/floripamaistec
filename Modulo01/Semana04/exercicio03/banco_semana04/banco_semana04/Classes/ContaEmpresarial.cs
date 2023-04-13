using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banco_semana04.Classes.@enum;

namespace banco_semana04.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        public ContaEmpresarial(int num, int agen, Cliente c) : base(num, agen, c)
        {
            if (c.TipoPessoa != ETipoPessoa.JURIDICA)
            {
                throw new ArgumentException("Cliente deve ser pessoa jurídica!\n");
            }
        }
    }
}
