﻿using System;
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

        /* Exercício 04:
         Crie um método para depositar valores na conta bancária.

        Descrição:

        Crie um método dentro da classe ContaBancaria que permita fazer depósito de valores nesta conta. 
        Pontos importantes a serem observados:

        O valor de depósito deve ser recebido como parâmetro no método;
        O valor a ser depositado deve ser maior do que 0;
        */
        public void Deposito(decimal monto)
        {
            if (monto <= 0)
                Console.WriteLine("O deposito deve ser maior que 0.");
            else
                saldo = saldo + monto;
        }

        /* Exercício 05:
         Crie um método para possibilitar o saque de valores da conta bancária.

        Descrição:

        Crie um método dentro da classe ContaBancaria que permita fazer saque de valores nesta conta. 
        Pontos importantes a serem observados:

        O valor de saque deve ser recebido como parâmetro no método;
        O valor a ser sacado deve ser maior do que 0;
        O valor de saque não pode ser maior que o saldo atual da conta;
        */
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

        /*
         Crie um método para exibir o saldo atual da conta bancária.
        Descrição:
        Crie um método dentro da classe ContaBancaria que o saldo atual da conta.
        */
        public void ExibeSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é {saldo}");
        }
    }
}
