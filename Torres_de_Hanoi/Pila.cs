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
        public string Id { get; }
        public int Size;
        public Disco Top { get; set; }
        public List<Disco> Elementos { get; set; }
       

        public Pila(string identPila)   // Identificativo de pila
        {
            this.Id = identPila;
            this.Size = 0;              // Tamaño de la lista por pila
            this.Top = null;            // Disco más alto por pila 
            this.Elementos = new List<Disco>(); // Lista por pila
        }

        public void push(Disco d) // Disco d es un disco que declaramos en Hanoi
        {
            this.Elementos.Add(d); // Añade el disco al final de la pila.
            this.Size++;           // Agranda la lista
            this.Top = d;          // Asigna el disco más alto
        }


        public Disco pop()          
        {
            if (this.Elementos.Count == 0)
            {
                this.Size--;
                return null;
                
            }
            else
            { 
                // Se obtiene el último elemento de la lista y se elimina de la misma
                Disco ultimoElemento = this.Elementos[this.Elementos.Count - 1];
                this.Elementos.RemoveAt(this.Elementos.Count - 1);
                this.Size--;
                return ultimoElemento;
            }
        }


        public bool isEmpty()       // Comprobar si esta vacio
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

