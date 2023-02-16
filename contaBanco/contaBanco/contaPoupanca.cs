using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBanco
{
    class ContaPoupanca : Conta
    {
        public override void juro()
        {
            this.saldo += 1;
        }

        public void depositar(double valor)
        {
            base.depositar(valor);
            base.saldo += 1;
        }
    }
}
