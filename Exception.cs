using System;
namespace Learn
{
    public class Exception
    {
        public Exception()
        {
        }

        public static void throwException() {
            throw new IndexOutOfRangeException();
        }

        public static void throwNewException() {
            throw new DivideByZeroException();
        }

        public static void catchException() {
            try {
                throwException();
                throwNewException();
            } catch (IndexOutOfRangeException e) {
                Console.WriteLine(e.StackTrace);
            } catch (DivideByZeroException e) {
                Console.WriteLine(e.StackTrace);
            } finally {
                Console.WriteLine("fininally");
            }
        }

        public static void MyMain() {
            catchException();
        }
    }
}
