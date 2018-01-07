using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverteMatriz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var matriz = new int[,] { { 1, 2, 3 }, { 0, 1, 4 }, { 5, 6, 0 } };

            var matrizConvertida = InverterMatriz(matriz);

            for (int i = 0; i < matrizConvertida.GetLength(0); i++)
            {
                for (int j = 0; j < matrizConvertida.GetLength(1); j++)
                {
                    Console.Write(string.Concat(matrizConvertida[i, j], " "));
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        private static int[,] InverterMatriz(int[,] matriz)
        {
            var retorno = (int[,])matriz.Clone();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    retorno[j, i] = matriz[i, j];
                }
            }

            return retorno;
        }
    }
}
