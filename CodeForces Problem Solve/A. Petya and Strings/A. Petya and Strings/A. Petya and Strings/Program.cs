using System;

namespace A._Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstString = Console.ReadLine();
            var firstString=FirstString.ToLower();
            var SecondString = Console.ReadLine();
            var secondString = SecondString.ToLower();
            var result=firstString.CompareTo(secondString);
            Console.WriteLine(result);

        }
    }
}
