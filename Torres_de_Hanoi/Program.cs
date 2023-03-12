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
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            /*
            Disco d1 = new Disco(1);
            Disco d2 = new Disco(2);
            Disco d3 = new Disco(3);
            */

            Console.WriteLine("Bienvenido al juego de las Torres de Hanoi");
            Console.Write("Por favor, introduce el número de discos que quieres jugar: ");
            int numDiscos = Convert.ToInt32(Console.ReadLine());

            // Agregamos los discos a la torre inicial
            for (int i = numDiscos; i > 0; i--)
            {
                Disco disco = new Disco(i);
                ini.push(disco);
            }

            Hanoi juegoHanoi = new Hanoi();
            int movimientos = juegoHanoi.iterativo(numDiscos, ini, fin, aux);


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

