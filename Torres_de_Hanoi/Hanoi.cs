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
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (!a.isEmpty() && (b.isEmpty() || a.Top.Valor < b.Top.Valor))
            {
                Disco discoAux = a.pop();
                b.push(discoAux);
                Console.WriteLine("Se movió el disco " + discoAux.Valor + " desde la pila " + a +" hasta la pila " + b);
            }
            else
            {
                Console.WriteLine("NO SE PUEDE REALIZAR LA OPERACIÓN");
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
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                    mover_disco(aux, ini);
                    mover_disco(fin, ini);
                    mover_disco(fin, aux);

                    mov += 3;
                }
            }
            else
            {
                while (mov < movPred)
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);
                    mov += 3;
                }
            }

            return (int)mov;

        }
    }
}

 