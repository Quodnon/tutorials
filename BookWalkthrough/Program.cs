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
            Random rnd = new Random(); //инициализируем генератор случайных чисел
            float[] myArray;

            int n = rnd.Next(5, 10); //генерируем случайное число из диапазона [5..10) 
            myArray = new float[n]; 
            
            for (int i = 0; i < n; i++)

            {

                myArray[i] = rnd.Next(10); // заполняем массив случайными числами

            }

            foreach (int elem in myArray) //выводим массив на экран
            {

                Console.Write("{0} ", elem);

            }
            Console.ReadLine();

        }

    }

}