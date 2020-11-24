using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PrintUpper( string str) {
                Console.WriteLine(str.ToUpper());
            }
            static void PrintLower( string str) {
                Console.WriteLine(str.ToLower());
            }
        }
    }
}
