using System;
using System.Linq;
namespace Learn
{
    public class Method
    {
        public static int devide(int first, int second = 1) {
            return first / second;
        }

        public static void MyMain() {
            int[] numbers = {5, 3, 6, 7, 3 };
            Console.WriteLine(numbers.Average());
            Console.WriteLine(devide(second: 2, first: 4));
            Console.WriteLine(devide(first: 3));

            Console.WriteLine("abcdeabd".CountChar('a'));
        }
    }

    public static class Extension
    {
        public static int CountChar(this string str, char target) {
            int count = 0;
            foreach(char c in str) {
                if (c == target) {
                    count += 1;
                }
            }
            return count;
        }
    }
}
