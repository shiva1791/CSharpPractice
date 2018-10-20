using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class ClassE
    {
        public ClassE(int a)
        {
            Console.WriteLine($"Constructor with integer value {a}");
        }
        public ClassE(long b)
        {
            Console.WriteLine($"Constructor with long value {b}");
        }
    }
}
