using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Id { get; }
        public int Size;
        public Disco Top { get; set; }
        public List<Disco> Elementos { get; set; }
       

        public Pila(int identPila)
        {
            this.Id = identPila;
            this.Size = 0;
            this.Top = null;
            this.Elementos = new List<Disco>();
        }

        public void push(Disco d) // Disco d es un disco que declaramos en Hanoi
        {
            this.Elementos.Add(d); // Añade el disco al final de la pila.
            this.Size++;
            this.Top = d;
        }


        public Disco pop()
        {
            if (this.Elementos.Count == 0)
            {
                return null;
            }
            else
            { 
                // Se obtiene el último elemento de la lista y se elimina de la misma
                Disco ultimoElemento = this.Elementos[this.Elementos.Count - 1];
                this.Elementos.RemoveAt(this.Elementos.Count - 1);
                return ultimoElemento;
            }
        }


        public bool isEmpty()
        {
            if(this.Elementos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}

