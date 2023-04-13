﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Classes.Enum;

namespace Banco.Classes
{
    public class ContaBancaria
    {
        /*
         * [M1S03] Ex 3 - Alteração de visibilidade da classe ContaBancaria
         Em continuação ao Exercício 01 desta semana, altere a visibilidade de todos os 
        atributos da classe ContaBancaria para serem agora campos privados.
         */
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular = "";
        private decimal _saldo = 0;
        private ETipoConta _tipoConta;

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
            _nomeDoTitular= nome;
            _agencia= ag;
            _numero= num;
            _tipoConta= tconta;
        }

        public void Deposito(decimal monto)
        {
            if (monto <= 0)
                Console.WriteLine("O deposito deve ser maior que 0.");
            else
                _saldo = _saldo + monto;
        }

        public void Saque(decimal monto)
        {
            if (monto <= 0)
                Console.WriteLine("O saque deve ser maior que 0.");
            else if (monto > _saldo)
                Console.WriteLine("O saque não pode ser maior do que o saldo disponível.");
            else
            {
                _saldo = _saldo - monto;
            }
        }

        public void ExibeSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é {_saldo}");
        }

        public void ImprimeDados()
        {
            Console.WriteLine("\n*** Dados da Conta: ");
            Console.WriteLine("  Nome:{0}\n  Agencia: {1}\n  Número:{2}\n  Tipo: {3}\n",_nomeDoTitular,_agencia,_numero,_tipoConta);
        }
    }
}
