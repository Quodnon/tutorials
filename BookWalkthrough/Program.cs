using System;


namespace BookWalkthrough
{
    class Program
    {
        static void Func() //дополнительный метод
        {

            Console.Write("x= ");

            double x = double.Parse(Console.ReadLine()); double y = x * x;

            Console.WriteLine("y({0})={1}", x, y);

        }

        static void Main() //точка входа в программу
        {
            int d=int.Parse(Console.ReadLine());
            for (int i = 1; i <= d;i++ ){
                Func(); //первый вызов метода Func
            }
            Console.ReadLine();
        }
    }
}
