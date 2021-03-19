using System;
/* 使用事件机制，模拟实现一个闹钟功能。
 * 闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
 * 在闹钟走时时或者响铃时，在控制台显示提示信息*/
namespace TickAndAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DateTime time = new DateTime();
            time = DateTime.Now.AddSeconds(10);
            clock.SetAlarm(time);
            clock.Start();
        }
    }
}
//实现功能的clock类
class Clock
{
    DateTime alarmTime = new DateTime();
    //事件委托定义
    public delegate void AlarmHandler(object sender, DateTime args);
    public delegate void TickHandler(object sender, DateTime args);
    //事件创建
    public event AlarmHandler AlarmOn;
    public event TickHandler TickOn;
    //在构造方法中进行事件订阅
    public Clock() {
        AlarmOn += Alarm;
        TickOn += Tick;
    }
    //编写Alarm和Tick的方法
    public void Alarm(object sender,DateTime time)
    {
        Console.WriteLine("闹钟报时：" + time);
    }
    public void Tick(object sender,DateTime time)
    {
        Console.WriteLine("北京时间：" + time);
    }

    //补充测试中用到的功能
    public void SetAlarm(DateTime time)
    {
        Console.WriteLine(time);
        alarmTime = time;
    }
    public void Start()
    {
        while (true)
        {
            DateTime now = DateTime.Now;
            TickOn(this, now);
            if (now.ToString() == alarmTime.ToString())
            {
            AlarmOn(this, alarmTime);
            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}