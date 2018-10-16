using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Constructors_Example3
    {
        public Constructors_Example3(int a)
        {
            Console.WriteLine($"The value is int {a}");
        }

        public Constructors_Example3(long b)
        {
            Console.WriteLine($"The value is long {b}");
        }

        public Constructors_Example3(string s)
        {
            Console.WriteLine($"The value is {s}");
        }

        public Constructors_Example3()
        {
            Console.WriteLine("default constructor with a parameterized constructor");
        }
    }
}
