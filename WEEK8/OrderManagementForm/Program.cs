using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Homework_8;

namespace Homework_8
{
    public class Order : IComparable<Order>
    {
        private List<OrderItem> items;

        public uint OrderId { get; set; }

        public String Customer { get; set; }

        public DateTime CreateTime { get; set; }


        public Order() { items = new List<OrderItem>(); CreateTime = DateTime.Now; }

        public Order(uint orderId, string customer, List<OrderItem> items)
        {
            this.OrderId = orderId;
            this.Customer = customer;
            this.items = (items == null) ? new List<OrderItem>() : items;
        }

        public List<OrderItem> Items
        {
            get { return items; }
        }

        public double TotalPrice
        {
            get => items.Sum(item => item.TotalPrice);
        }
        public OrderItem GetItem(uint index)
        {
            return items.Where(o => o.Index == index).FirstOrDefault();
        }
        public void AddItem(OrderItem orderItem)
        {
            if (Items.Contains(orderItem))
                throw new ApplicationException($"orderItem-{orderItem} is already existed!");
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }
        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{OrderId}, customer:{Customer},orderTime:{CreateTime},totalPrice：{TotalPrice}");
            items.ForEach(od => strBuilder.Append("\n\t" + od));
            return strBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            var hashCode = -531220479;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + CreateTime.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderId.CompareTo(other.OrderId);
        }
    }
}

public class OrderItem
{

    public uint Index { get; set; } //序号

    public String GoodsName { get; set; }

    public uint Quantity { get; set; }

    public double Price { get; set; }

    public OrderItem() { }

    public OrderItem(uint index, String goodsName, double price, uint quantity)
    {
        this.Index = index;
        this.GoodsName = goodsName;
        this.Price = price;
        this.Quantity = quantity;
    }

    public double TotalPrice
    {
        get => Price * Quantity;
    }


    public override string ToString()
    {
        return $"[No.:{Index},goods:{GoodsName},quantity:{Quantity},totalPrice:{TotalPrice}]";
    }

    public override bool Equals(object obj)
    {
        var item = obj as OrderItem;
        return item != null &&
               GoodsName == item.GoodsName;
    }

    public override int GetHashCode()
    {
        var hashCode = -2127770830;
        hashCode = hashCode * -1521134295 + Index.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
        hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
        return hashCode;
    }
}

public class OrderService
{
    //the order list
    private List<Order> orders;


    public OrderService()
    {
        orders = new List<Order>();
    }

    public List<Order> Orders
    {
        get => orders;
    }

    public Order GetOrder(uint id)
    {
        return orders.Where(o => o.OrderId == id).FirstOrDefault();
    }

    public void AddOrder(Order order)
    {
        if (orders.Contains(order))
            throw new ApplicationException($"Add Order Error: Order with id {order.OrderId} already exists!");
        orders.Add(order);
    }

    public void RemoveOrder(uint orderId)
    {
        Order order = GetOrder(orderId);
        if (order != null)
        {
            orders.Remove(order);
        }
    }

    public List<Order> QueryOrdersByGoodsName(string goodsName)
    {
        var query = orders
                .Where(order => order.Items.Exists(item => item.GoodsName == goodsName))
                .OrderBy(o => o.TotalPrice);
        return query.ToList();
    }

    public List<Order> QueryOrdersByCustomerName(string customerName)
    {
        return orders
            .Where(order => order.Customer == customerName)
            .OrderBy(o => o.TotalPrice)
            .ToList();
    }

    public void UpdateOrder(Order newOrder)
    {
        Order oldOrder = GetOrder(newOrder.OrderId);
        if (oldOrder == null)
            throw new ApplicationException($"Update Error：the order with id {newOrder.OrderId} does not exist!");
        orders.Remove(oldOrder);
        orders.Add(newOrder);
    }

    public void Sort()
    {
        orders.Sort();
    }

    public void Sort(Func<Order, Order, int> func)
    {
        Orders.Sort((o1, o2) => func(o1, o2));
    }

    public void Export(String fileName)
    {
        XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
        using (FileStream fs = new FileStream(fileName, FileMode.Create))
        {
            xs.Serialize(fs, Orders);
        }
    }

    public void Import(string path)
    {
        XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            List<Order> temp = (List<Order>)xs.Deserialize(fs);
            temp.ForEach(order => {
                if (!orders.Contains(order))
                {
                    orders.Add(order);
                }
            });
        }
    }
}