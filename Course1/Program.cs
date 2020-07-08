using System;
using System.Globalization;


namespace Course1 {
    class Program {
        static void Main(string[] args) {

            ContaBancaria C1;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Entre um valor para depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                C1 = new ContaBancaria(numero, titular, depositoInicial);
                     } else {
                C1 = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(C1);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C1.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(C1);

            Console.WriteLine();
            Console.Write("Entre um valor para saque");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C1.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(C1);


        }

    }
}



