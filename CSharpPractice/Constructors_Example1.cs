using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Constructors_Example1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class with only one default constructor");
            Constructors_Example1 example1 = new Constructors_Example1();

            Console.WriteLine("Class with only one default constructor and one static constructor");
            Constructors_Example2 example2 = new Constructors_Example2();

            Console.ReadKey();
        }

        public Constructors_Example1()
        {
            Console.WriteLine("I am default constructor");
        }        
    }
}
