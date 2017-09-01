using System;
namespace Learn
{
    public static class Nullable
    {
        public static void MyMain() {
            int? num = null;
            Console.WriteLine(num);
            Console.WriteLine(num ?? 1);
        }
    }

    public static class StringUtils
    {
        public static bool IsNull(this string str) {
            return str == null;
        }
    }
}
