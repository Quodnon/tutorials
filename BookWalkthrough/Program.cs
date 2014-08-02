using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWalkthrough
{
    public class World
    {
        public string name;
        public World(string name)
        {
            this.name = name;
        }
        public void createMoon() {
            Console.WriteLine("MOOOON");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("22324");
            Console.WriteLine("22324");
            Console.WriteLine("Hello my sweat World");
            Console.ReadLine();
           
            World planet = new World("Earth");
            Console.WriteLine(planet.name);
            string a;
            a = Console.ReadLine();
            switch (a)
            {
                case "2":
                    planet.createMoon();
                    break;
                default:
                    break;
            }
                    Console.ReadLine();
                
        }
    }
}
