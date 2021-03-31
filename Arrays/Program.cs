using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork();
        }

        static void HomeWork()
        {
            Console.Write("Введите размерность массива: n=");

            int n = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}]= ", i);
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

            string s1 = string.Empty;
            Console.WriteLine(s1);
            Console.Write("Массив: ");

            foreach (int elem in Array)
            {
                Console.Write("{0} ", elem);
            }

            int maxValue = Array[0];

            for (int i = 1; i < n; i++)
            {
                if (Array[i] > maxValue)
                {
                    maxValue = Array[i];

                }
            }

            Console.ReadLine();
            //string s2 = string.Empty;
            //Console.WriteLine(s2);
            //Console.WriteLine("Наибольшее число: " + maxValue);

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
