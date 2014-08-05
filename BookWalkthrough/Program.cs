using System;

// для работы с Generic мы подключаем специальный класс

using System.Collections.Generic;
using System.Text;

namespace Example
{

    class Program
    {

        // Данный метод меняет значения двух переменных типа <T>. Тип Т пока

        //не конкретизирован

        static void Swap<T>(ref T a, ref T b)
        {

            Console.WriteLine("Передаем в Swap() метод {0}", typeof(T)); T temp; temp = a; a = b;

            b = temp;

        }

        static void Main(string[] args)
        {
            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int elem in myArray)
            {

                Console.Write("{0} ",elem* elem);

            }
            Console.ReadLine();

        }

    }

}