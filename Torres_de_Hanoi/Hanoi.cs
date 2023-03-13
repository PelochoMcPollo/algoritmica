using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void mover_disco(Pila a, Pila b)
        {
            if (b.isEmpty())
            {
                b.push(a.pop());
            }
            else
            {
                if (a.Top < b.Top && !a.isEmpty()) 
                {
                    b.push(a.pop());
                }
                else 
                {
                    a.push(b.pop());
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila aux, Pila fin)
        {
            int m = 0;
            Console.WriteLine("Situación inical:");
            Console.Write("Torre ini: ");
            for (int i = 0; i < ini.Size; i++)
            {
                Console.Write(ini.Elementos[i].Valor + " ");
            }
            Console.WriteLine();
            Console.Write("Torre aux: ");
            for (int i = 0; i < aux.Size; i++)
            {
                Console.Write(aux.Elementos[i].Valor + " ");
            }
            Console.WriteLine();
            Console.Write("Torre fin: ");
            for (int i = 0; i < fin.Size; i++)
            {
                Console.Write(fin.Elementos[i].Valor + " ");
            }
            Console.WriteLine();
           
                if (n % 2 != 0)
                {
                    while (fin.Size != n)
                    {
                    
                        //-----------------INI FIN------------------
                        mover_disco(ini, fin);
                        m++;
                        Console.WriteLine("Situación tras el movimiento: " + m);
                        Console.Write("Torre ini: ");
                        for (int i = 0; i < ini.Size; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre aux: ");
                        for (int i = 0; i < aux.Size; i++)
                        {
                            Console.Write(aux.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre fin: ");
                        for (int i = 0; i < fin.Size; i++)
                        {
                            Console.Write(fin.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        if(fin.Size == n)
                        {
                            break;
                        }


                    //-----------------INI AUX------------------
                    mover_disco(ini, aux);
                        m++;
                        Console.WriteLine("Situación tras el movimiento: " + m);
                        Console.Write("Torre ini: ");
                        for (int i = 0; i < ini.Size; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre aux: ");
                        for (int i = 0; i < aux.Size; i++)
                        {
                            Console.Write(aux.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre fin: ");
                        for (int i = 0; i < fin.Size; i++)
                        {
                            Console.Write(fin.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                       

                        //-----------------AUX FIN------------------
                        mover_disco(aux, fin);
                        m++;
                        Console.WriteLine("Situación tras el movimiento: " + m);
                        Console.Write("Torre ini: ");
                        for (int i = 0; i < ini.Size; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre aux: ");
                        for (int i = 0; i < aux.Size; i++)
                        {
                            Console.Write(aux.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre fin: ");
                        for (int i = 0; i < fin.Size; i++)
                        {
                            Console.Write(fin.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                    

                }
                }
                else
                {
                    while(fin.Size != n) 
                    { 
                        //-----------------INI AuX------------------
                        mover_disco(ini, aux);
                        m++;
                        Console.WriteLine("Situación tras el movimiento: " + m);
                        Console.Write("Torre ini: ");
                        for (int i = 0; i < ini.Size; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre aux: ");
                        for (int i = 0; i < aux.Size; i++)
                        {
                            Console.Write(aux.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre fin: ");
                        for (int i = 0; i < fin.Size; i++)
                        {
                            Console.Write(fin.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                  

                    //-----------------INI FIN------------------
                    mover_disco(ini, fin);
                        m++;
                        Console.WriteLine("Situación tras el movimiento: " + m);
                        Console.Write("Torre ini: ");
                        for (int i = 0; i < ini.Size; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre aux: ");
                        for (int i = 0; i < aux.Size; i++)
                        {
                            Console.Write(aux.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre fin: ");
                        for (int i = 0; i < fin.Size; i++)
                        {
                            Console.Write(fin.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                    

                    //-----------------AUX FIN------------------
                    mover_disco(aux, fin);
                        m++;
                        Console.WriteLine("Situación tras el movimiento: " + m);
                        Console.Write("Torre ini: ");
                        for (int i = 0; i < ini.Size; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre aux: ");
                        for (int i = 0; i < aux.Size; i++)
                        {
                            Console.Write(aux.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Torre fin: ");
                        for (int i = 0; i < fin.Size; i++)
                        {
                            Console.Write(fin.Elementos[i].Valor + " ");
                        }
                        Console.WriteLine();
                     
                        
                    }
                }
            return m;
        }
    }
}
