using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorOrdenado
{
    public class Program
    {

        private static int[] Vetor = { 1, 2, 30 };
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (ValidarNumero(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        private static bool ValidarNumero(int numero)
        {
            return Vetor.Any(x => x.Equals(numero));
        }
    }
}
