using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NulElemnts
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 30;
            int i = 0;
            int j = 0;
            int[] mas = new int[count];
            int[] nul = new int[count];
            Random rnd = new Random();
            Console.WriteLine("Массив:");
            for (i = 0; i < count; i++)
            {
                mas[i] = rnd.Next(5);
                Console.Write(mas[i] + " ");
                if (mas[i] == 0)
                {
                    nul[j] = i;
                    j++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Индексы нулевых элементов:");
            for (i = 0; i < nul.Length; i++)
            {
                Console.Write(nul[i] + " ");
            }
            Console.Read();
        }
    }
}