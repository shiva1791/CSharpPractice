using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class ClassD
    {
        public ClassD():this(10)
        {
            Console.WriteLine("Default constructor for ClassD");
        }

        public ClassD(int a)
        {
            Console.WriteLine( "Chained constructor");
        }
    }
}
