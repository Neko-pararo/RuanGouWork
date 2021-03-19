using System;
using System.Collections;
/*为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
  通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）*/
namespace ActionT
{
    class Program
    {
        static void Main(string[] args)
        
            {
                GenericList<int> list = new GenericList<int>();
                for (int i = 0; i < 10; i++)
                {
                    list.Add(i);
                }
                int max = list.Head.Data;
                int min = list.Head.Data;
                int sum = 0;
                list.ForEach(n => Console.WriteLine(n));
                list.ForEach(n => sum += n);
                list.ForEach(n => { max = max > n ? max : n; });
                list.ForEach(n => { min = min < n ? min : n; });

                Console.WriteLine("max：" + max);
                Console.WriteLine("min：" + min);
                Console.WriteLine("sum：" + sum);


            }
        
    }
}
// 根据示例代码写出泛型链表类
public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data { get; set; }

    public Node(T t)
    {
        Next = null;
        Data = t;
    }
}
public class GenericList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public GenericList()
    {
        tail = head = null;
    }

    public Node<T> Head
    {
        get => head;
    }

    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        
    }
    // 实现foreach方法
    public void ForEach(Action<T> action)
    {
         for (Node<T> m = head; m.Next != null; m = m.Next)
            {
                action(m.Data);
            }
        }

    }

