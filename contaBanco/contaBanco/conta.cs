using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBanco
{
    abstract class Conta
    {
        protected double saldo = 0;

        public void sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo = this.saldo - valor;
                Console.WriteLine("Saque de: " + valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void depositar(double valor)
        {
            this.saldo = this.saldo + valor;
            Console.WriteLine("Depósito de: " + valor);
            this.juro();
        }

        public void verSaldo()
        {
            Console.WriteLine("Seu saldo é: " + this.saldo);
        }

        public double verSaldo2()
        {
            return this.saldo;
        }

        public abstract void juro();
    }
}
