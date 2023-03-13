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
        double mov = 0;
        public void mover_disco(Pila a, Pila b)
        {
            if (!a.isEmpty() && (b.isEmpty() || a.Top.Valor < b.Top.Valor)) // Comprueba que 'a' no esté vacía y que 'b' sí lo esté.
            {
                Disco discoAux = a.pop();
                b.push(discoAux);

                Console.WriteLine("Se movió el disco " + discoAux.Valor + " desde la pila " + a.Id + " hasta la pila " + b.Id);

                Console.WriteLine();


            
           
            }
            else // Sino no puede hacer nada.
            {
                mov--;
                // Console.WriteLine("No Hace desde la pila " + a.Id + " a " + b.Id);

            }
        }

        public int iterativo(int numDisc, Pila ini, Pila fin, Pila aux)
        {
            double movPred = Math.Pow(2, numDisc) - 1;

            if (movPred % 2 == 1) // Si es par o impar hace un while u otro.
            {

                while (mov < movPred) // While -> Hace los movimientos mientras pueda.
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



                }//WhilemovPredmovPred
            }// If
            else
            {
                while (fin.Elementos.Count < numDisc)
                {
                    mover_disco(ini, fin);
                    mov += 1;
                    if(fin.Elementos.Count < numDisc)
                    {
                        mover_disco(ini, aux);
                        mov += 1;
                        mover_disco(aux, fin);
                        mov += 1;
                    }
                }//While
            }

            return (int)mov;
        
        }//Iterativo
    }// Class
}// Hanoi