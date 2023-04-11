using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_Pares_Consecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O programa deve ler um valor inteiro X indefinidas vezes. 
            //(O programa irá parar quando o valor de X for igual a 0).
            //Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X, se for par.
            //Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4 + 6 + 8 + 10 + 12,
            //enquanto que se o valor de entrada for 11, por exemplo, a saída deve ser 80, que é a soma de 12 + 14 + 16 + 18 + 20.

            //Entrada
            //O arquivo de entrada contém muitos valores inteiros.O último valor do arquivo é zero.

            int X, soma = 0;
            do
            {
                X = int.Parse(Console.ReadLine());
                if(X % 2 == 0 && X != 0)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        if (X % 2 == 0)
                        {
                            soma += X;
                            i--;
                        }
                        X++;
                    }
                    Console.WriteLine(soma);
                    soma = 0;
                }
                else if(X % 2 != 0 && X != 0)
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        if (X % 2 == 0)
                        {
                            soma += X;
                            i--;
                        }
                        X++;
                    }
                    Console.WriteLine(soma);
                    soma = 0;
                }
            } while (X != 0);
            Console.ReadKey();
        }
    }
}
