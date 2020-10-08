using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massivy_21variant_3zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько слов хотите ввести?");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] S21 = new string[n];
            Console.WriteLine("Вводите слова через новую сроку");
            for (int i = 0; i < n; i++)
            {
                S21[i] = Console.ReadLine();
            }
            for (int i = 0; (i < n - 1)&(i % 2 == 0); i+=4)
            {
                string rr = S21[i + 2];
                for (int j = i + 2; j < n; j++)
                {
                    S21[j] = S21[i];
                    S21[i] = rr;
                    break;
                }
            }
            Console.WriteLine("Выводим слова:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(S21[i]);
            }










            Console.ReadLine();
        }
    }
}
