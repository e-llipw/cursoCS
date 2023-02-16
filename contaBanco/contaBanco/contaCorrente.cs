using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBanco
{
    class ContaCorrente : Conta, ICPMF
    {
        public void calculaTributo()
        {
            this.saldo -= 1;
        }

        public override void juro()
        {
            this.saldo -= 1;
        }

        //overriding
        public void sacar(double valor)
        {
            //invocar metodo da classe pai
            base.sacar(valor);
            this.saldo -= this.saldo;
            this.calculaTributo();
        }
    }
}
