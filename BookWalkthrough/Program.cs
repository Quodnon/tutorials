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

            int a = 1, b = 2;

            Console.WriteLine("Перед swap: {0}, {1}", a, b);

            Swap<int>(ref a, ref b); //передаем в Swap целый тип

            Console.WriteLine("После swap: {0}, {1}", a, b); Console.WriteLine(); 
            
            double x = 3.2, y = -123.27;
            Console.WriteLine("Перед swap: {0} {1}", x, y);

            Swap<double>(ref x, ref y);
            string z = "ds", f = "sd";
            Swap<string>(ref z, ref f );

            Console.WriteLine("После swap: {0} {1}", z, f);

            Console.ReadLine();

        }

    }

}