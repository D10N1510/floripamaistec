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
    }
}
