using System;

namespace Tarea05_12
{
    class Program
    {
        static Random alea = new Random();
        static public int generaNumero(int n1, int n2)
        {
            int resultado = alea.Next(n1, n2);
            return resultado;
        }
        static void Main(string[] args)
        {
            int[] lista = new int[10];
            int suma = 0;

            Console.WriteLine("Lista de 10 números: ");
            for (int i = 0; i < 10; i++)
            {
                lista[i] = generaNumero(1, 50);
                suma = suma + lista[i];
                Console.Write(" {0}, ", lista[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Media artmética = {0}", suma/10);
            Console.ReadKey();
        }
    }
}
