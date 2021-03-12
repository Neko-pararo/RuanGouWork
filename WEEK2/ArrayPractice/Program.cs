using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("以下是数组[1，2，3，4，5，6，7]的分析数据");
            ArrayAnalyzeData arrayAnalyzeData = new ArrayAnalyzeData();
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            arrayAnalyzeData.Test(a);
        }
    }
}
    class ArrayAnalyzeData
{
    public void Test(int []array)
    {
        int min = array[0];
        int max = array[0];
        int sum = 0;
        int arrange = 0;

        for(int i=0;i<array.Length;i++)
        {
            if (array[i]< min) { min = array[i]; }
            if (array[i]> max) { max = array[i]; }
            sum = sum + array[i];
        }

        arrange = sum / array.Length;
        Console.WriteLine("数组的最大值:"+max);
        Console.WriteLine("数组的最小值:" + min);
        Console.WriteLine("数组所有数和:" + sum);
        Console.WriteLine("数组平均值:" + arrange);
    }
}
