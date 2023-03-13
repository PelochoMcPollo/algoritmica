using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
 
        public int Top { get; set; }

        public List<Disco> Elementos { get; set; } = new List<Disco>();
        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
        }

        public Pila(int n)
        {
            for (int i = n; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;  
              this.Elementos.Add(disco);
            }
            this.Size = n;
            this.Top = this.Elementos[this.Size-1].Valor;

        }

        public void push(Disco d)
        {
            this.Elementos.Add(d);
            this.Size++;
            this.Top = d.Valor;
        }


        public Disco pop()
        {
            Disco disco = new Disco();
            disco = this.Elementos[this.Size - 1];
            this.Elementos.Remove(disco);
            this.Size--;
            this.Top=0;
            if (this.Size != 0) {
                this.Top = this.Elementos[this.Size - 1].Valor;
            }
            return disco;
        }                

        public bool isEmpty()
        {
            if(this.Size != 0) return false;
            return true;
        }

    }
}
