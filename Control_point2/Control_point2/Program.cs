using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_point2
{
    class Massiv
    {
        public int[] mass;
        private int Kolich_50 = 0;
        public int Max = 0;
        public int IndexMax = 0;
        public int Sum = 0;
        
        public Massiv(int S, int St, int F )
        {
            
            if ((S <= 0)||(F - St < 0))
            {
               Console.WriteLine("Ошибка: недопустимый размер массива или позиций Старт/Финиш");
                
               return;
            }   
            else
            {
               mass = new int[S];
               Random rnd = new Random();
               for (int i = 0; i < S; i++)
               {
                   mass[i] = rnd.Next(St, F);
                   if (mass[i] == 50)
                   {
                        Kolich_50 = Kolich_50 + 1;
                   }
               }
            }
                
        }
        public Massiv(string N2)
        {
            mass = N2.Split().Select(Int32.Parse).ToArray();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == 50)
                {
                    Kolich_50 = Kolich_50 + 1;
                }
            }

        }
        public int Kolvo => Kolich_50;
        public int Summ()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Abs(mass[i]) > Max)
                {
                    Max = Math.Abs(mass[i]);
                    IndexMax = i;
                }
            }
            for(int i = 0; i< IndexMax; i++)
            {
                Sum = Sum + (Math.Abs(mass[i]));
            }
            return Sum;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Massiv M = new Massiv("2 1 50 4");
            M.mass[1] = 50;
            
            Massiv Ma = new Massiv(2, 4, 3);
            Massiv Mas = new Massiv(2, 1, 3);
            Console.WriteLine(M.mass[3]);
            Console.WriteLine(M.Kolvo);
            Console.WriteLine(M.Summ());
            Console.ReadKey();

        }
    }
}
