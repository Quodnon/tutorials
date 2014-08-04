using System;


namespace BookWalkthrough
{
    class Program
    {
        static int Func(int x, int y) // 1
        {

            return (x > y) ? x : y;

        }

        static void Main()
        {

            Console.Write("a=");

            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");

            int b = int.Parse(Console.ReadLine()); 
            Console.Write("c="); 
            int c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            int d = int.Parse(Console.ReadLine()); 
            int max = Func(Func(Func(a, b), c),d); 
            Console.WriteLine("max({0}, {1}, {2},{3})={4}", a, b, c ,d, max);
            Console.ReadLine();
        }
    }
}
