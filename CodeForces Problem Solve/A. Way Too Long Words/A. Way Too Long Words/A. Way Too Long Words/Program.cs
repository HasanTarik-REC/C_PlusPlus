using System;

namespace A._Way_Too_Long_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 0;
            n = int.Parse(Console.ReadLine());
            while (count != n)
            {
                var Array1 = Console.ReadLine();
                if (Array1.Length > 10)
                {
                    int x = Array1.Length;
                    Console.Write(Array1[Array1.Length - x]);
                    Console.Write(x-2);
                    Console.WriteLine(Array1[Array1.Length-1]);
                }
                else
                    Console.WriteLine(Array1);
                count++;
            }
        }
    }
}
