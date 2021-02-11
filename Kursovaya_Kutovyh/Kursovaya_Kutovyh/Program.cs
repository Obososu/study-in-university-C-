using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Kursovaya_Kutovyh
{
    class Maintenance
    {
        /*
         * Класс предназначен для записи данных, полученных в ходе первичного осмотра камер в многоквартирном доме с целью проведения дальнейшего тех. обслуживания
         * В файл "vse.csv" осуществляется запись ВСЕХ таких визитов
         */
        public Maintenance()
        {

        }
        public Maintenance(string path, string ThisDay, int vidTO, int sostSeti, int ispravnSist)
        {
          
        }
        public string Zapis(string path, string ThisDay, int vidTO, int sostSeti, int ispravnSist)
        {
            /*
             * Метод предназначен для записи введенных данных в csv файл
             */
            string vid = "";
            if (vidTO == 1)
            {
                vid = "Montly";
            }
            else
            {
                vid = "Quarterly";
            }
            if (File.Exists(path + "vse.csv")) 
            {
                File.AppendAllText(path + "vse.csv", ThisDay + "," + vid + "," + sostSeti + "," + ispravnSist + "\n");
                return "";
            }
            else
            {
                File.WriteAllText(path + "vse.csv", "Data, vid TO, Sostoyanie Seti, Ispravnost seti\n");
                File.AppendAllText(path + "vse.csv", ThisDay + "," + vid + "," + sostSeti + "," + ispravnSist + "\n");
                return "";
            }
        }
             
    }
    class MonthlyMaintenance : Maintenance
    {
        /*
         * Класс предназначен для записи данных, полученных в ходе первичного осмотра камер в многоквартирном доме с целью проведения дальнейшего тех. обслуживания в ходе месячного ТО
         * В файл "monthly.csv" осуществляется запись визитов по месячному ТО 
         */
        public MonthlyMaintenance(string path, string ThisDay, int sostSeti, int ispravnSist, int ispravnPit)
        {

        }
        public string ZapisM(string path, string ThisDay, int sostSeti, int ispravnSist, int ispravnPit)
        {
            /*
             * Метод предназначен для записи введенных данных в csv файл
             */
            if (File.Exists(path + "monthly.csv"))
            {
                File.AppendAllText(path + "monthly.csv", ThisDay + "," + sostSeti + "," + ispravnSist + "," + ispravnPit + "\n");
                return "";
            }
            else
            {
                File.WriteAllText(path + "monthly.csv", "Data, vid TO, Sostoyanie Seti, Ispravnost seti, Ispravnost pitaniya\n");
                File.AppendAllText(path + "monthly.csv", ThisDay + "," + sostSeti + "," + ispravnSist + "," + ispravnPit + "\n");
                return "";
            }
        }
    }
    class QuarterlyMaintenance : Maintenance
    {
        /*
         * Класс предназначен для записи данных, полученных в ходе первичного осмотра камер в многоквартирном доме с целью проведения дальнейшего тех. обслуживания в ходе квартального ТО
         * В файл "quarterly.csv" осуществляется запись визитов по квартальному ТО 
         */
        public QuarterlyMaintenance(string path, string ThisDay, int sostSeti, int ispravnSist, int chistka)
        {

        }
        public string ZapisQ(string path, string ThisDay, int sostSeti, int ispravnSist, int chistka)
        {
            /*
             * Метод предназначен для записи введенных данных в csv файл
             */
            if (File.Exists(path + "quarterly.csv"))
            {
                File.AppendAllText(path + "quarterly.csv", ThisDay + "," + sostSeti + "," + ispravnSist + "," + chistka + "\n");
                return "";
            }
            else
            {
                File.WriteAllText(path + "quarterly.csv", "Data, vid TO, Sostoyanie Seti, Ispravnost seti, Chistka\n");
                File.AppendAllText(path + "quarterly.csv", ThisDay + "," + sostSeti + "," + ispravnSist + "," + chistka + "\n");
                return "";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"B:\Proverki\"; // рабочая директория
            int sostSeti = 0; // переменная для оценки сети
            int vidTO = 0; // переменная для вида ТО
            int ispravnSist = 0; // переменная для оценки системы
            try
            {
                Console.WriteLine("Здравствуйте, это программа для записей технического обслуживания камер наблюдения многокваритирного дома.");

                do
                {
                    Console.WriteLine("Укажите вид ТО:\n    1. Месячное\n    2. Квартальное");
                    vidTO = Convert.ToInt32(Console.ReadLine());
                    if ((vidTO == 1) || (vidTO == 2))
                    {
                        break;
                    }
                } while (true);
                bool osmotr = false; // переменная, отвечающая на вопрос "проводился ли осмотр?"
                do
                {
                    Console.WriteLine("Проводился ли внешний осмотр? Укажите цифру ответа:\n    1. Да\n    2. Нет");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        osmotr = true;
                        break;
                    }
                    else if (a == 2)
                    {
                        break;
                    }

                } while (true);


                if (osmotr) // если проводился, то указываем оценку
                {
                    do
                    {
                        Console.WriteLine("Оцените внешнее состояние сети от 1 до 10:");
                        sostSeti = Convert.ToInt32(Console.ReadLine());
                        if ((sostSeti > 0) && (sostSeti < 11))
                        {
                            break;
                        }
                    } while (true);


                }
                bool ispravnost = false; // переменная, отвечающая на вопрос "проводилась ли проверка исправности?"
                do
                {
                    Console.WriteLine("Проводилась ли проверка исправности? Укажите цифру ответа:\n    1. Да\n    2. Нет");

                    int b = Convert.ToInt32(Console.ReadLine());
                    if (b == 1)
                    {
                        ispravnost = true;
                        break;
                    }
                    else if (b == 2)
                    {
                        break;
                    }
                } while (true);


                if (ispravnost) // если проводилась, то указываем оценку
                {
                    do
                    {
                        Console.WriteLine("Оцените исправность системы от 1 до 10:");
                        ispravnSist = Convert.ToInt32(Console.ReadLine());
                        if ((ispravnSist > 0) && (ispravnSist < 11))
                        {
                            break;
                        }
                    } while (true);
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Ошибка ввода данных, перезапустите программу");
            }
            DateTime thisDay = DateTime.Today; // сегодняшняя дата
            string ThisDay = thisDay.ToString("d"); // конвертация в строку
            try
            {
                if (vidTO == 1)
                {
                    int ispravnPit = 0;
                    do
                    {
                        Console.WriteLine("Оцените исправность схем питания от 1 до 10:");
                        ispravnPit = Convert.ToInt32(Console.ReadLine());
                        if ((ispravnPit > 0) && (ispravnPit < 11))
                        {
                            break;
                        }
                    } while (true);

                    MonthlyMaintenance MonthlyMaintenance1 = new MonthlyMaintenance(path, ThisDay, sostSeti, ispravnSist, ispravnPit); // создание объекта
                    MonthlyMaintenance1.ZapisM(path, ThisDay, sostSeti, ispravnSist, ispravnPit); // вызов метода

                }
                else
                {
                    int chistka = 0;
                    do
                    {
                        Console.WriteLine("Необходима ли чистка оборудования? Укажите цифру ответа:\n    1. Да\n    2. Нет");
                        chistka = Convert.ToInt32(Console.ReadLine());
                        if ((chistka == 1) || (chistka == 2))
                        {
                            break;
                        }
                    } while (true);

                    QuarterlyMaintenance QuarterlyMaintenance1 = new QuarterlyMaintenance(path, ThisDay, sostSeti, ispravnSist, chistka); // создание объекта
                    QuarterlyMaintenance1.ZapisQ(path, ThisDay, sostSeti, ispravnSist, chistka); // вызов метода
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Ошибка ввода данных, перезапустите программу");
            }
            
            Maintenance Maintenance1 = new Maintenance(path, ThisDay, vidTO, sostSeti, ispravnSist); // создание объекта
            Maintenance1.Zapis(path,ThisDay,vidTO,sostSeti,ispravnSist); // вызов метода
            Console.ReadLine();
        }
    }
}
