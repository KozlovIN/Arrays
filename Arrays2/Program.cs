using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork2();
        }

        static void HomeWork2()
        {
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[n];
            Console.Write("Введите сам массив: ");

            for (int i = 0; i < n; i++)
            {
                Array[i] = Console.ReadKey().KeyChar - '0';
            }

           
            Console.ReadLine();
            Console.Write("Массив: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(Array[i]);
            }
            Console.ReadLine();


            
            int maxValue = Array[0];

            for (int i = 1; i < n; i++)
            {
                if (Array[i] > maxValue)
                {
                    maxValue = Array[i];

                }
            }

          
            //string s2 = string.Empty;
           // Console.WriteLine(s2);
           // Console.WriteLine("Наибольшее число: " + maxValue);

            int secondMaxValue = Array[0];

            for (int i = 1; i < n; i++)
            {
                if (Array[i] > secondMaxValue && Array[i] < maxValue)
                {
                    secondMaxValue = Array[i];

                }
            }

            string s3 = string.Empty;
            Console.WriteLine(s3);
            Console.WriteLine("Второе наибольшее число: " + secondMaxValue);
        }

    }
}
