using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massivy_21variant_1zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество учеников:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баллы по дисциплинам:");
            Console.WriteLine("(если баллов нет - поставьте ноль)");
            int[][] Students = new int[n][];
            for (int i = 0; i<n; i++)
            {
                Students[i] = new int[8];
            }
            for (int i = 0; i < n; i++)
            {
                
                string qq = "Введите оценки " + (i + 1) + " ученика через пробел";
                Console.WriteLine(qq);
                string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < 8; j++)
                {
                    Students[i][j] = Convert.ToInt32(str[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                int predm = 0;
                for (int j = 0; j < 8; j++)
                {
                    
                    if (Students[i][j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        sum = sum + Students[i][j];
                        predm++;
                    }
                    
                }
                double x = (double)sum / (double)predm;

                Console.WriteLine("Средний балл " + (i+1) + " ученика равен: " + Math.Round(x, 2));
            }












            Console.ReadLine();

        }
    }
}
