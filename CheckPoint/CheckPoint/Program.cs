using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double a = 0;
            Console.WriteLine("Чтобы завершить программу, введите z");
            while (true)
            {
                Console.WriteLine("Введите переменную a:");
                try
                {
                    string str = Console.ReadLine();
                    if (str == "z") return;
                    a = Convert.ToDouble(str);
                    break;
                }
                catch
                {
                    Console.WriteLine("А вы точно ввели число? Попробуйте еще раз!");
                }
            }

            double b = 0;
            while (true)
            {
                Console.WriteLine("Введите переменную b:");
                try
                {
                    string str = Console.ReadLine();
                    if (str == "z") return;
                    b = Convert.ToDouble(str);
                    break;
                }
                catch
                {
                    Console.WriteLine("А вы точно ввели число? Попробуйте еще раз!");
                }
            }

            double c = 0;
            while (true)
            {
                Console.WriteLine("Введите переменную c:");
                try
                {
                    string str = Console.ReadLine();
                    if (str == "z") return;
                    c = Convert.ToDouble(str);
                    break;
                }
                catch
                {
                    Console.WriteLine("А вы точно ввели число? Попробуйте еще раз!");
                }
            }

            double x = 0;
            while (true)
            {
                Console.WriteLine("Введите переменную x:");
                try
                {
                    string str = Console.ReadLine();
                    if (str == "z") return;
                    x = Convert.ToDouble(str);
                    break;
                }
                catch
                {
                    Console.WriteLine("А вы точно ввели число? Попробуйте еще раз!");
                }
            }

            double X = 0;
            while (true)
            {
                Console.WriteLine("Введите переменную X:");
                try
                {
                    string str = Console.ReadLine();
                    if (str == "z") return;
                    X = Convert.ToDouble(str);
                    break;
                }
                catch
                {
                    Console.WriteLine("А вы точно ввели число? Попробуйте еще раз!");
                }
            }

            double dx = 0;
            while (true)
            {
                Console.WriteLine("Введите переменную dx:");
                try
                {
                    string str = Console.ReadLine();
                    if (str == "z") return;
                    dx = Convert.ToDouble(str);
                    break;
                }
                catch
                {
                    Console.WriteLine("А вы точно ввели число? Попробуйте еще раз!");
                }
            }
            bool ok;
            var AC = (int)a;
            var BC = (int)b;
            var CC = (int)c;
            if (~(AC ^ BC ^ CC) == 0)
                ok = true;
            else ok = false;

            double rez = 0;
            try
            {
                for (double i = x; X >= i; i += dx)
                {
                    if ((x < 0) && (b != 0)) rez = -a * i * i + b;
                    else
                    if ((x > 0) && (b == 0)) rez = i / (i - c) + 5.5;
                    else rez = -x / c;
                    
                }
                if (ok) Console.WriteLine(rez);
                else Console.WriteLine((int)rez);

            }
            catch(DivideByZeroException)
            { Console.WriteLine("Ошибка DivideByZero");

            }
            catch { Console.WriteLine("Ошибка"); }




































            Console.ReadLine();
            

        }
    }
}
