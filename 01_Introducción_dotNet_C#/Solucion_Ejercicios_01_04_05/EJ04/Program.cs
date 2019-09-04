using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosEncontrados = 0;
            int sumaDivisores;

            for(int i = 1; numerosEncontrados < 4; i++)
            {
                sumaDivisores = 0;

                for(int j = i-1; j>0; j--)
                {
                    if(i % j == 0)
                    {
                        sumaDivisores += j;
                    }
                }

                if(sumaDivisores==i)
                {
                    Console.WriteLine("Numero perfecto: {0}", i);
                    numerosEncontrados++;
                }                
            }
            Console.ReadKey();
        }
    }
}
