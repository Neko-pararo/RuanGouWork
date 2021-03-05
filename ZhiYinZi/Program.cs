using System;

namespace ZhiYinZi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入想要求质因子的整数");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine("所得所有质因子如下：");
            Zyz zyz = new Zyz();
            zyz.GetZyz(n);

        }
    }
}
    class Zyz
{
    public void GetZyz(int x)
    {
        for(int i = 2; i<=x; i++)
        {
            if(x%i == 0)
            {
                x = x / i;
                Console.WriteLine(x + "");
            }
        }
    }
}    
