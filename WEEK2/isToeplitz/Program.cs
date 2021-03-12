using System;

namespace isToeplitz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sample = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Toeplize toeplize = new Toeplize();
            Console.WriteLine("是否为Toeplize矩阵？:"+toeplize.Judge(sample));
            
        }
    }
}
     class Toeplize
{
    public bool Judge (int[,]arrays) {
        bool flag = true;
       for (int i = 0; i < arrays.GetLength(0)-1; i++)  
           for (int j = 0;j< arrays.GetLength(1)-1; j++)
            {
                if (arrays[i,j] != arrays[i + 1,j + 1]) {
                    flag = false;
                    break;
                }
            }
        return flag;
        
    }
}
