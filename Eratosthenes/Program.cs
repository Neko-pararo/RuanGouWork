using System;

namespace Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("用埃氏筛法筛出的，2-100的素数有：");
            int n = 100;
            bool[] array = new bool[n + 1];
            for (int i = 2; i < n; i++)
            {
                array[i] = true;
            }
            for (int i = 2; i < n; i++)
            {
                if (array[i])
                {
                    for (int j =2; j*i < n; j++)
                    {
                        array[j*i] = false;
                    }
                }
            }
            for(int i = 2; i < n; i++)
            {
                if (array[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
