using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    // El mas pequeño tendrá valor de 1 y el más grande tendrá valor de n, que en nuestros caso será 3
    class Disco
    {
        public int Valor { get; }

        public Disco(int valorDisco)
        {
            this.Valor = valorDisco;

        }//() Constructor Disco

    }// () Class Disco

}// () Namespace
