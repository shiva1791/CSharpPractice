using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class with only one default constructor");
            Constructors_Example1 example1 = new Constructors_Example1();

            Console.WriteLine("Class with only one default constructor and one static constructor");
            Constructors_Example2 example2 = new Constructors_Example2();

            Console.WriteLine("Class with a parametrized constructor");
            Constructors_Example3 example3 = new Constructors_Example3();
            Constructors_Example3 example3_1 = new Constructors_Example3(25);
            Constructors_Example3 example3_2 = new Constructors_Example3("APPLE");

            Console.ReadKey();
        }
    }
}
