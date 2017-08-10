using System;

namespace Learn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            ArrayTest.MyMain();
			Console.WriteLine();
            CustomClass.MyMain();
            Console.WriteLine();
            Person.MyMain();
            PersonStruct.MyMain();
            Console.WriteLine();
            Rectangle.MyMain();
			Console.WriteLine();
            Calculator.MyMain();
        }
    }
}
