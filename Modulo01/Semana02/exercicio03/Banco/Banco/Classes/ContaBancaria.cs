using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Classes.Enum;

namespace Banco.Classes
{
    /*Exercício 03:
     Defina uma classe chamada ContaBancaria com os seguintes atributos: número, agência, nome do titular, saldo, tipo de conta.

    Descrição:

    O exercício consiste na criação de uma classe para criar um conta bancária. Os atributos da classe devem ser os seguintes:

    numero;
    agencia;
    nome do titular;
    saldo - deve iniciar em 0;
    tipo de conta - deve ser um Enum com duas opções válidas: CORRENTE ou POUPANCA;
    */
    public class ContaBancaria
    {
        public int numero;
        public int agencia;
        public string nomeDoTitular = "";
        public decimal saldo = 0;
        public ETipoConta tipoConta;

    }
}
