using System;

namespace ExampleGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"----------------------------------------------------------------------");
            Console.WriteLine(@"---                     Examples of Generics                       ---");
            Console.WriteLine(@"----------------------------------------------------------------------");

            Console.WriteLine(@"ClassGeneric<int> intGeneric = new ClassGeneric<int>(1);");
            ClassGeneric<int> intGeneric = new ClassGeneric<int>(1);
            intGeneric.GenericMethod(2);
            Console.WriteLine(@"----------------------------------------------------------------------");

            Console.WriteLine(@"ClassGeneric<double> floatGeneric = new ClassGeneric<double>(1.23);");
            ClassGeneric<double> floatGeneric = new ClassGeneric<double>(1.23);
            floatGeneric.GenericMethod(2.34);
            Console.WriteLine(@"----------------------------------------------------------------------");

            Console.WriteLine(@"ClassGeneric<string> strGeneric = new ClassGeneric<string>(""Init string"");");
            ClassGeneric<string> strGeneric = new ClassGeneric<string>("Init string");
            strGeneric.GenericMethod("Change string");
            Console.WriteLine(@"----------------------------------------------------------------------");

            Console.WriteLine(@"ClassGeneric<int> intGeneric2 = new ClassGenericInt(2);");
            ClassGeneric<int> intGeneric2 = new ClassGenericInt(2);
            intGeneric2.GenericMethod(200);
            Console.WriteLine(@"----------------------------------------------------------------------");

            Console.WriteLine(@"ClassGeneric<double> doubleGeneric2 = new ClassGenericChild<double>(5.64);");
            ClassGeneric<double> doubleGeneric2 = new ClassGenericChild<double>(5.64);
            doubleGeneric2.GenericMethod(6.78);
            Console.WriteLine(@"----------------------------------------------------------------------");

            Console.WriteLine(@"Press Enter to close.");
            Console.ReadLine();
        }
    }
}
