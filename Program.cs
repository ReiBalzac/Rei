using System;

namespace Сортировка
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many digits will there be in the string?");
            var kolichestvoPusirkov = int.Parse(Console.ReadLine());
            int[] mas = new int[kolichestvoPusirkov];

            Console.WriteLine("Enter max number");
            var maxSide = int.Parse(Console.ReadLine());
            Random rand = new Random();
            
            for (int i = 0; i < kolichestvoPusirkov; i++)
            {

                mas[i] = rand.Next(1, maxSide + 1);
               
            }


            for (int i = 0; i < kolichestvoPusirkov; i++)

            {

                {
                    Console.Write("{0 }, ", mas[i]);
                    
                }
            }
            
          
            for (int i = 0; i < kolichestvoPusirkov; i++)
           {
                for (int j = i + 1; j < kolichestvoPusirkov; j++)

                {
                    if (mas[i] > mas [j])
                    {
                        int t = mas[i];
                        mas[i] = mas[j];
                        mas[j] = t;
                    }
                     
                }
                Console.Write("{0 }, ", mas[i]);             




            }

        }
    }
}






