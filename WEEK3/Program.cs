using System;

namespace ShapeDefineAndCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            double allArea = 0;
            for (int i = 0; i < 10; i++)
            {
                Shape sp = Test.CreateShape(i);
                Console.Write("第" + (i + 1) + "个图形："+sp.GetName());
               
                allArea += sp.Area();
                Console.WriteLine("当前图形面积=" + sp.Area());
                Console.WriteLine("总面积" + allArea);
            }
            Console.WriteLine("十个图形总面积（含不合法图形）为：" + allArea);

        }

    }


    public abstract class Shape
    {

        public abstract double Area();//计算面积的方法
        public abstract string GetName(); //在getname的时侯同时判断是否可以构成相应图形，这里有些不好
        public bool flag = true;           //flag用于判断图形是否成立


    }

    public class Rectangle : Shape
    {
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        private double a { get; set; }
        private double b { get; set; }

        override
        public string GetName()
        {
            if (a > 0 && b > 0)
            {
                if (this.a == this.b) { return "正方形"; }
                else { return "长方形"; }
            }
            else { flag = false; return "无效的形状创建"; }
        }
        override
        public double Area()
        {
            if (flag)
                return a * b;
            else
                return 0;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r)
        {
            this.r = r;
        }
        private double r { get; set; }

        override
            public string GetName()
        {
            if (r > 0) return "圆形";
            else flag = false; return "无效的形状创建";
        }
        override
            public double Area()
        {
            if (flag) return Math.PI * r * r;
            else return 0;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        override
            public string GetName()
        {
            double[] edges = new double[] { a, b, c };
            double sum = edges[0] + edges[1] + edges[2];
            int succFlag = 0;
            for (int i = 0; i < edges.Length; i++)
            {
                if (edges[i] < sum - edges[i])
                {
                    succFlag++;
                }
            }
            if (succFlag == 3)
            {
                flag = true;
                return "三角形";
            }
            else
            {
                flag = false;
                return "无效的形状创建";
            }
        }
        override
            public double Area()
        { return 0.25 * Math.Sqrt((a + b + c) * (a + b - c) * (a + c - b) * (b + c - a)); }
    }

    public class Test
    {
        public static Shape CreateShape(int i)
        {
            Shape sp = null;
            Random rd;
            rd = new Random();
            int j;
            j = rd.Next(3);
            if (j == 0)
            {
                sp = new Circle(rd.NextDouble());
            }
            else if (j == 1)
            {
                sp = new Rectangle(rd.NextDouble(), rd.NextDouble());
            }
            else if (j == 2)
            {
                double a, b, c;
                a = rd.NextDouble();
                c = b = a;
                sp = new Triangle(a, b, c);
            }
            return sp;
        }
    }
}
