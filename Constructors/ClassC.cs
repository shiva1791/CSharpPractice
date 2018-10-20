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
        public ClassC()
        {
            Console.WriteLine("Default constructor for ClassC");
        }
    }
}
