using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_ponomarev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных 
            double a = 0, b = 0, c = 0, Xn = 0, Xk = 0, dX = 0, F;
            //Переменная для вывода ошибок и корректировок
            bool check;
            //Справка отмены
            Console.WriteLine("Для отмены введите: non");
            //Организация действия для цикла "пока ошибка есть"
            do
            {
                //Предложение ввести указанную переменную
                Console.WriteLine("Введите переменную a:");
                /*Организация процедуры исключения ошибок, 
                 *указанных в catch,в работе кода в части try */
                try
                {
                    //Запись введенного значения в консоль и проверка его на команду "Отмена"
                    string str = Console.ReadLine(); if (str == "non") return;
                    a = Convert.ToDouble(str); check = false; //Установления отсутвия ошибки ввода
                }
                //Указание исключения для try
                catch { Console.WriteLine("Ошибка! Введите ЧИСЛО!"); check = true; }
            }
            //Организация самого цикла "пока ошибка есть"
            while (check);
            /*ДАЛЕЕ АНАЛОГИЧНЫЕ ЦИКЛЫ ДЛЯ ОСТАВШИХСЯ 5-ТИ ПЕРЕМЕННЫХ,
             * ПОЭТОМУ ИХ НЕ ПОЯСНЯЮ, КРОМЕ ОШИБОК ВВОДА*/
            do
            {
                Console.WriteLine("Введите переменную b:");
                try
                {
                    string str = Console.ReadLine(); if (str == "non") return;
                    b = Convert.ToDouble(str); check = false;
                }
                catch { Console.WriteLine("Ошибка! Введите ЧИСЛО!"); check = true; }
            }
            while (check);
            do
            {
                Console.WriteLine("Введите переменную c:");
                try
                {
                    string str = Console.ReadLine(); if (str == "non") return;
                    c = Convert.ToDouble(str); check = false;
                }
                catch { Console.WriteLine("Ошибка! Введите ЧИСЛО!"); check = true; }
            }
            while (check);
            do
            {
                Console.WriteLine("Введите переменную Xn:");
                try
                {
                    string str = Console.ReadLine(); if (str == "non") return;
                    Xn = Convert.ToDouble(str); check = false;
                }
                catch { Console.WriteLine("Ошибка! Введите ЧИСЛО!"); check = true; }
            }
            while (check);
            do
            {
                Console.WriteLine("Введите переменную Xk:");
                try
                {
                    string str = Console.ReadLine(); if (str == "non") return;
                    Xk = Convert.ToDouble(str); check = false;
                    //Проверка условия корректного ввода
                    if ((double)Xk <= (double)Xn) check = true;
                    if (check == true) Console.WriteLine("Ошибка! Xk должен быть больше Xn");
                }
                catch { Console.WriteLine("Ошибка! Введите ЧИСЛО!"); check = true; }

            }
            while (check);
            do
            {
                Console.WriteLine("Введите переменную dX:");
                try
                {
                    string str = Console.ReadLine(); if (str == "non") return;
                    dX = Convert.ToDouble(str); check = false;
                    //Проверка условия корректного ввода
                    if ((double)Xn + (double)dX > (double)Xk) check = true;
                    if (check == true) Console.WriteLine("Ошибка! Xn+dX должен быть в указанном выше интервале");
                }
                catch { Console.WriteLine("Ошибка! Введите ЧИСЛО!"); check = true; }
            }
            while (check);
            //Console.ReadLine();

            //double a = 3, b = 6, c = 7, Xn = 3, Xk = 10, dX = 1;
            //Объявление перменной "значение функции"
            //double F;
            //Проверка коэффициентов на условие из варианта для правильного вывода значения F
            if ((~((int)a | (int)b) & ~((int)a | (int)c)) != 0) check = true;
            else check = false;
            /*Организация процедуры исключения ошибок, 
             *указанных в catch,в работе кода в части try */
            try
            {
                //Организация цикла перебора значений x в промежутке (Xn;Xk) с шагом в dX
                for (double x = Xn; Xk > x; x += dX)
                {
                    // Поиск значения функции F в зависимости от ограничений
                    if ((x < 0.3) && (b != 0)) F = (c - 2 * x) / (c * x - a);
                    else if ((x > 0.3) && (b == 0)) F = (x - a) / (x + c);
                    else F = (-x / c) + (-c / (2 * x));
                    // Вывод значения функции
                    Console.WriteLine("---------------------");
                    if (check) Console.WriteLine("| x = " + x + "  |  F = " + F.ToString("F2") + "|");
                    else Console.WriteLine("| x = " + x + "  |  F = " + (int)F + "|");
                }
            }
            //Перечисление исключений для try
            //Ошибка деления на ноль
            catch (DivideByZeroException) { Console.WriteLine("Ошибка DivideByZeroException"); }
            //Остальные ошибки
            catch { Console.WriteLine("Ошибка"); }
            //Задержка консоли для просмотра результатов
            Console.ReadLine();
        }
    }
}
