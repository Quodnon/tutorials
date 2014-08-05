using System;

// для работы с Generic мы подключаем специальный класс

using System.Collections.Generic;
using System.Text;

namespace Example
{

    class Program
    {

        //выводит на экран массив a
        static void Print(int[] a)
        {
            foreach (int elem in a)
            {
               Console.Write("{0} ", elem);
            }
            Console.WriteLine();
        }

        //Заменяет отрицательные элементы массива а на нули. //Размерность массива n. 
        static void Change(int[] a, int n)
        {
            for (int i = 0; i< n; i++)
            {
                if (a[i] < 0) {
                    a[i] = 0;
                } else {
                    a[i] *= 2;
                }
           }
        }
        static void Main()

            {

            int[] myArray = { 0, -1, -2, 3, 4, 5, -6, -7, 8, -9 };

            Console.Write("Исходный массив: ");

            Print(myArray);

            Change(myArray, 10);

            Console.Write("Измененный массив: ");

            Print(myArray);

            Console.ReadLine();

        }

    }

}