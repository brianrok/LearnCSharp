using System;
namespace Learn
{
    public class Enum
    {
        private enum WeekDays
        {
            Mon, Tue, Wed, Thu, Fir, Sat, Sun
        };

        [Flags]
        enum Days
        {
            NONE = 0x0,
            Sun = 0x1,
            Mon = 0x2,
            Tue = 0x4,
            Wed = 0x8,
            Thu = 0x10,
            Fri = 0x20,
            Sat = 0x40
        };
       
        public static void MyMain()
        {
            Console.WriteLine(WeekDays.Mon);
            Console.WriteLine(Days.Sun | Days.Mon);
        }
    }
}
