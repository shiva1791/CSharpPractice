using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class ClassC
    {
        public ClassC(int a)
        {
            Console.WriteLine($"The value is int {a}");
        }

        public ClassC(long b)
        {
            Console.WriteLine($"The value is long {b}");
        }

        public ClassC(string s)
        {
            Console.WriteLine($"The value is {s}");
        }

        public ClassC()
        {
            Console.WriteLine("default constructor with a parameterized constructor");
        }
    }
}
