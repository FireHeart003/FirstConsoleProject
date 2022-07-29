using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
    class MainClass
    {
        

        public static void Main(string[] args)
        {
            Console.WriteLine(Utility.CompareValue(3,3));
            Console.WriteLine(Utility.CompareTypes("hello", "world"));
            Console.ReadKey();
        }
    }

    class Utility
    {
        public static bool CompareValue<T01, T02>(T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }

        public static bool CompareTypes<T01, T02> (T01 type01, T02 type02)
        {
            return typeof(T02).Equals(typeof(T01));
        }

    }
}


/*
int diff = Math.Abs(input - (answer));
if (diff == 1)
{
    Console.WriteLine("So close!");
}
else if (diff <= 10)
{
    Console.WriteLine("You are not even close.");
}
else
{
    Console.WriteLine("You are not even close.");
}*/

