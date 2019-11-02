// TimeTest.cs
// Several Time objects created and output
using System;
using static System.Console;

public class TimeTest
{
    // Precondition:  None
    // Postcondition: Several Time objects created and output
    public static void Main(string[] args)
    {
        Time t1 = new Time(); // 00:00:00
        Time t2 = new Time(2); // 02:00:00
        Time t3 = new Time(21, 34); // 21:34:00
        Time t4 = new Time(12, 25, 42); // 12:25:42
        Time t5 = new Time(27, 74, 99); // invalid values

        WriteLine("Constructed with:\n");
        WriteLine("t1: all arguments defaulted");
        WriteLine($"   {t1}\n"); // 12:00:00 AM

        WriteLine(
           "t2: hour specified; minute and second defaulted");
        WriteLine($"   {t2}\n"); // 2:00:00 AM

        WriteLine(
           "t3: hour and minute specified; second defaulted");
        WriteLine($"   {t3}\n"); // 9:34:00 PM

        WriteLine("t4: hour, minute and second specified");
        WriteLine($"   {t4}\n"); // 12:25:42 PM

        WriteLine("t5: invalid values specified");
        WriteLine($"   {t5}\n"); // 12:00:00 AM
    }
}
