using ConsoleApp1;
using System;

namespace FunctionProgrames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Function obj = new Function();
            obj.show();

            AddFun obj1 = new AddFun();
            obj1.AddFunction(30, 30);

            Console.ReadLine();
        }
    }
}
