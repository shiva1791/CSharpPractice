using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class ClassB
    {
        static ClassB()
        {
            Console.WriteLine("I am a static constructor always called first for ClassB");
        }

        public ClassB()
        {
            Console.WriteLine("I am default constructor of ClassB");
        }
    }
}
