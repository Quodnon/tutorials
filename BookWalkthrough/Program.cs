using System;


namespace BookWalkthrough
{
    class Program
    {
        class Car
   
        {
            public string name;
            public int speed;
            public Car (string name) {
                this.name = name;
                this.speed = 100;
            }
            public void sayName() {
                Console.WriteLine(this.name);
                Console.WriteLine(this.name);
                Console.WriteLine(this.name);
                Console.WriteLine(this.name);
            }
            public int saySpeed() {
                return this.speed;
            }
        }

        static void Main(string[] args)
        {
            int a = 2;
            string fur = "hedgehog";
            Console.WriteLine("{0} {1}", a, fur);

            
            Car myCar = new Car("Ford");
                 
            myCar.sayName();
           
            Console.ReadLine();
        }
    }
}
