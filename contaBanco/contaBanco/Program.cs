using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca conta = new ContaPoupanca();
            //conta.verSaldo();

            Console.WriteLine(conta.verSaldo2());

            /*Console.WriteLine("Selecione uma conta: ");
            string tipo = Console.ReadLine();

            Conta conta = null;

            if (tipo=="1")
            {
                conta = new ContaCorrente();
            }
            else
            {
                conta = new ContaPoupanca();
            }

            conta.depositar(100);
            conta.verSaldo();
            conta.sacar(100);
            conta.verSaldo();

            ContaCorrente conta = new ContaCorrente();
            conta.depositar(101);
            conta.sacar(100);

            ContaPoupanca poup = new ContaPoupanca();
            poup.depositar(49);
            poup.sacar(50);

            Console.ReadKey();*/
        }
    }
}