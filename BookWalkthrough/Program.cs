using System;


namespace BookWalkthrough
{
    class Program
    {
        static double Func(double x) //дополнительный метод
        {

            if ( x>0 ) {
               return x * x;
            }
            else {
               return 1 / x; 
            } //возвращаемое значение

        }

        static void Main() //точка входа в программу
        {

            Console.Write("a=");

            double a = double.Parse(Console.ReadLine()); 
            Console.Write("b=");

            double b = double.Parse(Console.ReadLine()); 
            Console.Write("h="); 
            double h = double.Parse(Console.ReadLine());

            for (double x = a; x <= b; x += h)
            {

                double y = Func(x); //вызов метода Func

                Console.WriteLine("y({0:f1})={1:f2}", x, y);

            }
            Console.ReadKey();
        }
    }
}
