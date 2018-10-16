using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Constructors_Example2
    {
        static Constructors_Example2()
        {
            Console.WriteLine("I am a static constructor always called first");
        }

        public Constructors_Example2()
        {
            Console.WriteLine("I am default constructor");
        }
    }
}
