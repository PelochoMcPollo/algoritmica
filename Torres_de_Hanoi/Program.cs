using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {

  
        static void Main(string[] args)
        {
            Pila FIN = new Pila();
            Pila AUX = new Pila();
            Console.WriteLine("Por favor, indica el número de discos...");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Has seleccionado "+n+" discos");
            Pila INI = new Pila(n);

          
            Hanoi hanoi = new Hanoi();
            int mov = hanoi.iterativo(n, INI, AUX, FIN);

            Console.WriteLine("Resuelto en " + mov + " movimientos");

            Console.ReadKey();

        }
    }
}
