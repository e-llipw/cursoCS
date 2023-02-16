using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Carro
    {
        //atributos -> caracteristicas
        public string modelo = "";

        //metodos -> ações
        public void ligar()
        {
            Console.WriteLine("ligou!" + this.modelo);
        }
    }
}
