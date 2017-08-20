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
            Console.WriteLine();
            Method.MyMain();
			Console.WriteLine();
            Delegate.MyMain();
			Console.WriteLine();
			Enum.MyMain();
			Console.WriteLine();
            Exception.MyMain();
			Console.WriteLine();
            FileOperation.MyMain();
        }
    }
}
