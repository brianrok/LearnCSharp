using System;
namespace Learn
{
    public class Delegate
    {
        public delegate int PerformCalculation(int x, int y);

        public static int Add(int x, int y) {
            return x + y;
        }

        public static void MyMain() {
            PerformCalculation calculation = Add;
            Console.WriteLine(calculation(1, 2));
        }
    }
}
