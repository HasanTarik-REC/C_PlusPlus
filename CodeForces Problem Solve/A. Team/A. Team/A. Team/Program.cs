using System;

namespace A._Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0,n,p=0,count = 0;
            n = int.Parse(Console.ReadLine());
            while (count != n)
            {
                var line = Console.ReadLine().Split(' ');
                int[] array1 = new int[3];
                for (var i = 0; i < 3; i++)
                    array1[i] = int.Parse(line[i]);

                for (int j = 0; j < 3; j++)
                {
                    if (array1[j] == 1)
                    {
                        p++;
                    }
                }
                if (p > 1)
                {
                    a++;
                }
                p = 0;
                count++;
            }
            Console.WriteLine(a);
        }
    }
}
