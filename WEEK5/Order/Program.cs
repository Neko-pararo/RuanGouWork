using System;
using System.Collections.Generic;
using System.Linq;


namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            AllOrder a = new AllOrder();
            bool judge_ = true;
            while (judge_)
            {
                Console.WriteLine("输入1增加订单，输入2删除订单，输入3查询订单，输入4显示所有订单，输入5根据订单号为订单排序,输入6退出");
                string choose1 = Console.ReadLine();
                switch (choose1)
                {
                    case "1": a.addOrder(); break;
                    case "2": a.removeOrder(); break;
                    case "3": Console.WriteLine("输入1根据订单金额查询订单，输入2根据客户名查询订单");
                    int i = Convert.ToInt32(Console.ReadLine()); a.searchOrder(i); break;
                    case "4": a.ShowOrder(); break;
                    case "5": a.order.Sort(); break;
                    default: Console.WriteLine("输入错误"); break;
                }
            }
        }

        }
    }
}

public interface IOrderService //包含所有功能的接口（作为备忘）
{
    void AddOrder();
    void RemoveOrder();
    void SearchOrder(int i);
}

public class OrderItem
{
    private string _name;//学会使用两种属性来对内对外
    public string Name { get; set; }
    private int _num;
    public int Num { get; set; }
    private double _price;
    public double Price;
    public OrderItem(string name, int num, double price)
    {
        _name = name;
        _num = num;
        _price = price;
    }
    public double getPrice()
    {
        return _num * _price;
    }
    public class Order
    {
        public int Code { get; set; }
        public string CustomerName { get; set; }
        public double Money { get; set; }
        public string Date { get; set; }

        public List<OrderItem> orderItem = new List<OrderItem>();

        public Order(int code, string customerName, string date)
        {
            Code = code;
            CustomerName = customerName;
            Date = date;
        }
        public void GetTotalPrice()
        {
            double i = 0;
            foreach (OrderItem a in this.orderItem)
            {
                i += a.getPrice();
            }
            Money = i;
        }
        public void AddOrderItem(string name, int number, double price)
        {
            OrderItem orderitem = new OrderItem(name, number, price);
            this.orderItem.Add(orderitem);
        }
        public void RemoveOrderItem()
        {
            try
            {
                Console.WriteLine("输入订单号删除相应订单");
                int a = Convert.ToInt32(Console.ReadLine());
                orderItem.RemoveAt(a);
                Console.WriteLine("删除！");
            }
            catch { Console.WriteLine("Wrong!"); }
        }
        public void ShowOrderItem()
        {
            Console.WriteLine("Code Name Amount PriceForEach");
            foreach (OrderItem orderItem in this.orderItem)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} {1} {2} {3}", this.orderItem.IndexOf(orderItem), orderItem.Name, orderItem.Num, orderItem.Price);
            }
        }
    }
    public class AllOrder 
    {
        public List<Order> order = new List<Order>();
        public AllOrder() { }
        public void ShowOrder()
        {
            foreach (Order order in this.order)
            {
                Console.WriteLine("Num  Client  Date  TotalAmount");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("{0} {1} {2} {3}", order.Code, order.CustomerName, order.Date, order.Money);
                order.ShowOrderItem();
            }
        }
        public void addOrder()
        {
            try
            {
                Console.WriteLine("输入订单号");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入客户名称：");
                string customer = Console.ReadLine();
                Console.WriteLine("请输入时间：");
                string date = Console.ReadLine();
                Order a = new Order(code, customer, date);
                Console.WriteLine("输入订单项：");
                bool judge = true;
                bool same = false;
                foreach (Order m in this.order)
                {
                    if (m.Equals(a)) same = true;
                }
                if (same) Console.WriteLine("订单号重复");
                else
                {
                    while (judge && !same)
                    {
                        Console.WriteLine("请输入物品名称：");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入购买数量：");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入单价：");
                        double price = Convert.ToDouble(Console.ReadLine());
                        a.AddOrderItem(name, number, price);
                        Console.WriteLine("是否继续添加订单项：");
                        string x = Console.ReadLine();
                        if (x == "否") judge = false;
                        else if (x == "是") continue;
                        else if (x != "否" && x != "是")
                        {
                            Exception e = new Exception();
                            throw e;
                        }
                    }
                    order.Add(a);
                    a.GetTotalPrice();
                    Console.WriteLine("建立成功");
                    Console.WriteLine("-------------------------");
                }
            }
            catch
            {
                Console.WriteLine("输入错误");

            }
            void RemoveOrder()
            {
                try
                {
                    Console.WriteLine("输入订单号删除订单或相应明细：");
                    int code = Convert.ToInt32(Console.ReadLine());
                    int index = 0;
                    foreach (Order a in this.order)
                    {
                        if (a.Code == code) index = this.order.IndexOf(a);
                    }
                    Console.WriteLine("输入1删除订单，输入2继续删除订单明细");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1: this.order.RemoveAt(index); Console.WriteLine("删除成功"); Console.WriteLine("-----------------"); break;
                        case 2: this.order[index].ShowOrderItem(); this.order[index].RemoveOrderItem(); break;
                        default: Console.WriteLine("输入错误"); break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入错误");
                }

            }

            void SearchOrder(int i)
            {
                try
                {
                    switch (i)
                    {
                        case 1:
                            int minNum, maxNum;
                            Console.WriteLine("输入要查询的最小金额：");
                            minNum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("输入要查询的最大金额：");
                            maxNum = Convert.ToInt32(Console.ReadLine());


                            var query1 = from s1 in order
                                         where maxNum > s1.Money
                                         orderby s1.Money
                                         select s1;
                            var query3 = from s3 in query1
                                         where s3.Money > minNum
                                         orderby s3.Money
                                         select s3;

                            List<Order> a1 = query3.ToList();

                            foreach (Order b1 in a1)
                            {
                                Console.WriteLine("订单号 客户 日期 总金额");
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("{0} {1} {2} {3}", b1.Code, b1.CustomerName, b1.Date, b1.Money);
                                b1.ShowOrderItem();
                            }
                            break;
                        case 2:

                            Console.WriteLine("输入客户名称：");
                            string name1 = Console.ReadLine();

                            var query2 = from s2 in order
                                         where s2.CustomerName == name1
                                         orderby s2.Money
                                         select s2;
                            List<Order> a2 = query2.ToList();

                            foreach (Order b2 in a2)
                            {
                                Console.WriteLine("订单号 客户 日期 总金额");
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("{0} {1} {2} {3}", b2.Code, b2.CustomerName, b2.Date, b2.Money);
                                b2.ShowOrderItem();
                            }
                            break;
                        default: Console.WriteLine("输入错误"); break;

                    }
                }
                catch
                {
                    Console.WriteLine("输入错误");
                }
            }

        }
    }
}
