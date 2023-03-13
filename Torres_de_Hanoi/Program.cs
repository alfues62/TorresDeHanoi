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
            

            Pila ini = new Pila("Ini");
            Pila aux = new Pila("Aux");
            Pila fin = new Pila("Fin");


            Console.WriteLine("Bienvenido al juego de las Torres de Hanoi");
            Console.Write("Por favor, introduce el número de discos que quieres jugar: ");
            int numDiscos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Agregamos los discos a la torre inicial
            for (int i = numDiscos; i > 0; i--)
            {
                Disco disco = new Disco(i);
                ini.push(disco);
            }

            Hanoi juegoHanoi = new Hanoi();
            int movimientos = juegoHanoi.iterativo(numDiscos, ini, fin, aux);

            Console.WriteLine("Juego Completado en " + movimientos + " Movimientos.");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

