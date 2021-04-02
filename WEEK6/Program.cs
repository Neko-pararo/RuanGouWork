using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace week7
{
    class Program{
       public  static void main(string args)
        {
            Goods goods1 = new Goods("football", 1);                                          //测试数据
            Goods goods2 = new Goods("basketball", 2);
            Goods goods3 = new Goods("volleyball", 3);
            Goods goods4 = new Goods("water", 4);
            Goods goods5 = new Goods("chocolate", 5);

            Client client1 = new Client("z");
            Client client2 = new Client("zz");
            Client client3 = new Client("zzz");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem2 };
            OrderItem[] orderItems2 = { orderItem2, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };
            OrderItem[] orderItems4 = { orderItem2, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            order1.calculate();
            Order order2 = new Order(2, client2, orderItems2);
            order2.calculate();
            Order order3 = new Order(3, client3, orderItems4);
            order3.calculate();

            OrderService orderService = new OrderService();
            orderService.add(order2);
            orderService.add(order1);
            orderService.add(order3);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            orderService.modify(3, order3);
            Console.WriteLine();
            Console.Write("默认排序后的订单编号序列: ");
            orderService.sort();
            orderService.showID();
            Console.WriteLine();
            Console.WriteLine("删除订单编号为3的订单");
            orderService.sub(3);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine("\n");
            Console.WriteLine("查询z的订单");
            List<Order> zorders = orderService.querybyClient("z");
            foreach (Order order in zorders)
            {
                Console.WriteLine(order);
            }
            Console.WriteLine("\n");
            Console.WriteLine("查询购买了basketball的订单");
            List<Order> forders = orderService.querybyGoods("basketball");
            foreach (Order order in forders)
            {
                Console.WriteLine(order);
            }
            orderService.Export();
            orderService.Import();
            Console.ReadKey();
        }

}
    public class OrderService
    {
        public List<Order> _orderList = new List<Order>();
        public List<Order> OrderList { set; get; }
        public OrderService() { }
        public OrderService(List<Order> orders)
        {
            this._orderList = orders;
            OrderList = orders;
        }
        public void sort()                                                 //默认按照订单号排序
        {
            _orderList.Sort((p1, p2) => p1.OrderNum - p2.OrderNum);
        }
        public void add(Order order)                                       //添加订单
        {
            _orderList.Add(order);
        }
        public void sub(int id)                                           //根据订单号删除订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in _orderList)
                {
                    i++;
                    if (order.OrderNum == id)
                    {
                        j = i;
                    }
                }
                _orderList.RemoveAt(j);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单删除失败，请检查输入的订单号!");
            }
        }
        public void modify(int ordernum, Order neworder)                           //根据订单号修改订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in _orderList)
                {
                    i++;
                    if (order.OrderNum == ordernum)
                    {
                        j = i;
                    }
                }
                _orderList[j] = neworder;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单修改失败，请检查输入的订单号!");
            }
        }
        public Order getOrder(int id)                                              //按照订单号查询
        {
            var query = _orderList.Where(o => o.OrderNum == id);
            Order order = (Order)query;
            return order;
        }
        public List<Order> querybyClient(string name)                              //按照客户名查询
        {
            var query = _orderList.Where(o => o.Client.ClientName == name).OrderBy(o => o.Sum);
            return query.ToList();
        }
        public List<Order> querybyGoods(string name)                               //按照商品名查询
        {
            var query = _orderList.Where(o => {
                foreach (OrderItem orderItem in o.OrderItems)
                {
                    if (orderItem.Goods.GoodsName == name)
                    {
                        return true;
                    }
                }
                return false;
            }).OrderBy(o => o.Sum);
            return query.ToList();
        }
        public void showID()                                                       //输出订单编号
        {
            foreach (Order order in _orderList)
            {
                Console.Write(order.OrderNum + " ");
            }
        }
        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, _orderList);
            }
            Console.WriteLine("\nSerialized as xml");
            Console.WriteLine(File.ReadAllText("orderlist.xml"));
        }
        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Open))
            {
                _orderList = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from orderlist.xml");
            }
        }
    }
}

public class Order
{
    public int _orderNum;//订单编号
    public Client _client;//订单客户
    public OrderItem[] _orderItems;//订单明细
    public double _sum;
    public Order() { }
    public Order(int orderNum, Client client, OrderItem[] orderItems)
    {
        this._orderNum = orderNum;
        OrderNum = orderNum;
        this._client = client;
        Client = client;
        this._orderItems = orderItems;
        OrderItems = orderItems;
    }
    public int OrderNum { set; get; }
    public Client Client { set; get; }
    public OrderItem[] OrderItems { set; get; }
    public double Sum { set; get; }

    public void calculate()                                   //计算订单总金额
    {
        foreach (OrderItem orderItem in _orderItems)
        {
            _sum += (orderItem.Goods.GoodsPrice) * (orderItem.GoodsNum);
        }
    }
    public override string ToString()
    {
        StringBuilder details = new StringBuilder();
        foreach (OrderItem orderItem in _orderItems)
        {
            details.Append(orderItem.ToString());
        }
        return "\norderNum:" + _orderNum + "     ClientName:" + _client.ClientName + "     Sum:￥" + _sum + details;
    }
    public override bool Equals(object obj)                                                                  //自动生成
    {
        return obj is Order order &&
               _orderNum == order._orderNum &&
               EqualityComparer<Client>.Default.Equals(_client, order._client) &&
               EqualityComparer<OrderItem[]>.Default.Equals(_orderItems, order._orderItems) &&
               _sum == order._sum;
    }
    public override int GetHashCode()                                                                   //自动生成
    {
        var hashCode = -1839463946;
        hashCode = hashCode * -1521134295 + _orderNum.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(_client);
        hashCode = hashCode * -1521134295 + EqualityComparer<OrderItem[]>.Default.GetHashCode(_orderItems);
        hashCode = hashCode * -1521134295 + _sum.GetHashCode();
        return hashCode;
    }
}

public class Goods
{
    public string _goodsName;
    public double _goodsPrice;
    public Goods() { }
    public Goods(string name, double price)
    {
        //设置商品名称和价格
        this._goodsName = name;
        GoodsName = name;
        this._goodsPrice = price;
        GoodsPrice = price;
    }
    public string GoodsName { set; get; }
    public double GoodsPrice { set; get; }
    public override string ToString()
    {
        return "goodsName:" + _goodsName + " goodsPrice:" + _goodsPrice;
    }
}

public class OrderItem//订单明细项
{
    public Goods _goods;
    public int _goodsNum;
    public OrderItem() { }
    public OrderItem(Goods goods, int goodsNum)
    {
        this._goods = goods;
        Goods = goods;
        this._goodsNum = goodsNum;
        GoodsNum = goodsNum;
    }
    public Goods Goods { set; get; }
    public int GoodsNum { set; get; }
    public override bool Equals(object obj)
    {
        return obj is OrderItem item &&
               EqualityComparer<Goods>.Default.Equals(_goods, item._goods) &&
               _goodsNum == item._goodsNum;
    }
    public override int GetHashCode()
    {
        var hashCode = -1839463946;
        hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(_goods);
        hashCode = hashCode * -1521134295 + _goodsNum.GetHashCode();
        return hashCode;
    }

    public override string ToString()
    {
        return "\nGoodsname:" + _goods.GoodsName + "\ngoodsNum:" + _goodsNum + "\nGoodsPrice:￥" + _goods.GoodsPrice + "\n";
    }

}

public class Client
{
    public string _clientName;
    public Client() { }
    public Client(string name)
    {
        //设置客户姓名
        this._clientName = name;
        ClientName = name;
    }
    public string ClientName { set; get; }
    public override string ToString()
    {
        return "clientName:" + _clientName;
    }
}