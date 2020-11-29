using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {

        public string Name { get; set; }
        public int Num_conta { get; private set; }
        public double Saldo { get; set; }

        public ContaBancaria(string name, int num_conta)
        {
            Name = name;
            Num_conta = num_conta;
            
        }

        public ContaBancaria(string name, int num_conta, double depositoInicial) : this (name, num_conta)
        {
            Deposito(depositoInicial);
        
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        } 

        public void Saque (double quantia)
        {
            Saldo -= quantia + 5;
        }
            

        public override string ToString()
        {
            return "Conta " + Num_conta + ", Titular " + Name + " , $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
