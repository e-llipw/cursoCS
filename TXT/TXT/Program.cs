using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXT
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"E:\Cursos\cursoC#\TXT\curso.txt";

            Clientes cliente = new Clientes("Ellias",  caminho);
            cliente.apagar();
        }
    }
}