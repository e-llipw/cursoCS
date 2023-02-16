using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe
            Carro car = new Carro();
            car.modelo = "BMW";
            car.ligar();
            
            Carro car2 = new Carro();
            car2.modelo = "Volvo";
            car2.ligar();

            Console.ReadKey();
        }
    }
}