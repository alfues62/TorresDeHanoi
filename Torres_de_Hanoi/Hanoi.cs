using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torres_de_Hanoi;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void mover_disco(Pila a, Pila b)
        {

            if (!a.isEmpty() && b.isEmpty())
            {
                Disco discoAux = a.pop();
                b.push(discoAux);

                Console.WriteLine("Se movió el disco " + discoAux.Valor + " desde la pila " + a.Id + " hasta la pila " + b.Id);
                Console.WriteLine(a.Size);
                Console.WriteLine(b.Size);
            }
            else if (a.Top.Valor < b.Top.Valor)
            {
                Disco discoAux = a.pop();
                b.push(discoAux);

                Console.WriteLine("12332165Se movió el disco " + discoAux.Valor + " desde la pila " + a.Id + " hasta la pila " + b.Id);
                Console.WriteLine(a.Size);
                Console.WriteLine(b.Size);
            }
            else
            {

                Console.WriteLine("No Hace desde la pila ");
                Console.WriteLine(a.Size);
                Console.WriteLine(b.Size);

            }
        }

        public int iterativo(int numDisc, Pila ini, Pila fin, Pila aux)
        {
            double movPred = Math.Pow(2, numDisc) - 1;
            double mov = 0;

            if (movPred % 2 == 1)
            {

                while (mov < movPred)
                {
                    mover_disco(ini, fin);
                    mov += 1;
                    mover_disco(ini, aux);
                    mov += 1;
                    mover_disco(aux, ini);
                    mov += 1;
                    mover_disco(aux, fin);
                    mov += 1;
                    mover_disco(fin, ini);
                    mov += 1;
                    mover_disco(fin, aux);
                    mov += 1;
                }//While
            }// If

            return (int)mov;
        
        }//Iterativo
    }// Class
}// Hanoi