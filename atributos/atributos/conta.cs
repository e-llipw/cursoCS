using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atributos
{
    class Conta
    {
        //public
        //private
        //protect

        //atributos
        private double saldo = 0;
        public int agencia = 0;
        public int conta = 0;

        //metodos
        public void sacar(double valor, string tipoMoeda)
        {
            this.saldo = this.saldo-valor;
            Console.WriteLine("Realizado o saque de: " + valor + " com moeda " + tipoMoeda);
            this.juro();
            this.verSaldo();
        }

        private void juro()
        {
            this.saldo=this.saldo-1;
        }

        public void depositar(double valor)
        {
            this.saldo = this.saldo+valor;
            Console.WriteLine("Depósito realizado: " + valor);
            this.verSaldo();
        }

        public void verSaldo()
        {
            Console.WriteLine("Seu saldo é: " + this.saldo);
        }
    }
}
