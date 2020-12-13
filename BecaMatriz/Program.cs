using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cada Becario deverá criar um metódo para calcular a soma da diagonal principal de uma matriz quadrada 3 x 3 
            // O método deverá ter o nome do participante
            // exemplo: CalculaSomaDiagonalPrincipal_Ricardo();

            int[,] array33 = new int[3,3] { { 1, 2, 3 } , { 4, 5, 6 } , { 7, 8, 9 } };
            somarDiagonalPrincipal_Leticia(array33);
            Console.ReadLine();
        }

        public static void somarDiagonalPrincipal_Leticia(int[,] array33)
        {
            
            int soma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(" " + i + " " + j + " ---->" + array33[i, j]);
                    if (i == j)
                    {
                        soma += array33[i, j];
                    }
                }
                Console.WriteLine("---------------");
            }
            Console.WriteLine("TOTAL: " + soma);
        }
    }
}
