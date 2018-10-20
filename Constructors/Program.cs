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
            Console.WriteLine("--CLASS WITH ONLY ONE DEFAULT CONSTRUCTOR--");
            ClassA Obj1= new ClassA(); // In this case only the default constructor is called

            Console.WriteLine(Environment.NewLine); 
            Console.WriteLine("--CLASS WITH ONLY ONE DEFAULT CONSTRUCTOR AND ONE STATIC CONSTRUCTOR--");
            ClassB Obj2 = new ClassB(); // In this case the static constructor is called before the default constructor

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--CLASS WITH A PARAMETRIZED CONSTRUCTOR--");            
            ClassC Obj3 = new ClassC(25); //This will call the parameterized constructor only

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--CLASS WITH CONSTRUCTOR CHAINING--");
            ClassD Obj4 = new ClassD(); // This will call the chained constructor first and then the default constructor

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--CLASS WITH TWO PARAMETERIZED CONSTRUCTOR--");
            ClassE Obj5 = new ClassE(10); // This will call the constructor with integer value since 10 falls in integer category
            ClassE Obj6 = new ClassE((long)10); // This will call the constructor with long value since we explicitly cast 10 to b a long
            ClassE Obj7 = new ClassE(9999999999); // This will call the constructor with long value since the value exceeds the integer default size

            Console.ReadKey();
        }
    }
}
