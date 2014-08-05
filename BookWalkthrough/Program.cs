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
            int[] myArray; //создаем ссылку на массив 
            Console.Write("n= ");
            int n=int.Parse(Console.ReadLine());

            myArray = new int[n]; //выделяем память под массив требуемой длины 
            
            for (int i=0; i<n; i++) //вводим элементы массива с клавиатуры
            {
                Console.Write("A[{0}]= ", i);
                myArray[i] = int.Parse(Console.ReadLine());

            }

            foreach (int elem in myArray) //выводим массив на экран
            {

              if (elem>0)
              {
                  Console.Write("{0} ", elem);
              } else {
                  continue;
              };
            }
            Console.ReadLine();

        }

    }

}