using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (IsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        private static bool IsPrimo(int numero)
        {
            if (numero == 1)
            {
                return false;
            }
            if (numero == 2)
            {
                return true;
            }
            if (numero % 2 == 0)
            {
                return false;
            }
            var raiz = Math.Sqrt(numero);
            var fronteira = (int)Math.Floor(raiz);
            for (int i = 3; i <= fronteira; i += 2)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
