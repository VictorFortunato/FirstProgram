using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.WriteLine("Digite o numero da conta: ");
            int num_conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.WriteLine("Digite seu nome: ");
            String name = Console.ReadLine();

            Console.WriteLine("Deseja realizar deposito inicial? y/n?" );
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'y')
            {
                Console.WriteLine("Digite o valor do deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(name, num_conta, deposito);

            }
            else {
                conta = new ContaBancaria(name, num_conta);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine("Entre o valor para deposito: ");
            double deposito1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito1);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("Digite o valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
