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
            ClassA example1 = new ClassA();

            Console.WriteLine("Class with only one default constructor and one static constructor");
            ClassB example2 = new ClassB();

            Console.WriteLine("Class with a parametrized constructor");
            ClassC example3 = new ClassC();
            ClassC example3_1 = new ClassC(25);
            ClassC example3_2 = new ClassC("APPLE");

            Console.ReadKey();
        }
    }
}
