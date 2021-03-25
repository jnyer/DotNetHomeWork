using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    public class TimeArgs
    {
        public int Second { get; set; }
        public int Minute { get; set; }
        public int Hour { get; set; }
    }
    public delegate void TickHandler(object sender,TimeArgs args);
    public class ClockFunction
    {
        private int hour, minute, second, alarmHour, alarmMinute, alarmSecond;
        public event TickHandler OnTick;
        public event TickHandler OnAlarm;
        public ClockFunction(int hour, int minute,int second)  
        {
            if (hour < 60 && minute < 60&& second < 60)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }
            else
            {
                throw new Exception("error:Time setting is illegal!");
            }
        }
        public void SetAlarm(int aHour,int aMinute,int aSecond)
        {
            if (aHour < 60 && aMinute < 60 && aSecond < 60)
            {
                this.alarmHour = aHour;
                this.alarmMinute = aMinute;
                this.alarmSecond = aSecond;
            }
            else
            {
                throw new Exception("error:Alarm setting is illegal!");
            }
        }
        public void Run()
        {
            while (true)
            {
                if (this.second < 59) { this.second++; }
                else
                {
                    this.second = 0;
                    this.minute++;
                    if (this.minute == 60)
                    {
                        this.minute = 0;
                        this.hour = (this.hour + 1) % 24;
                    }
                }
                TimeArgs currentTime = new TimeArgs() { Hour = hour, Minute = minute, Second = second };
                if (this.hour == this.alarmHour && this.minute == this.alarmMinute && this.second==this.alarmSecond)
                {
                    OnAlarm(this, currentTime);
                }
                else
                {
                    OnTick(this, currentTime);
                }
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
    class Clock
    {
        public ClockFunction clock;
        public Clock(int hour,int minute,int second)
        {
            clock = new ClockFunction(hour, minute, second);
            clock.OnTick += Clock_OnTick;
            clock.OnAlarm += Clock_OnAlarm;
        }

        private void Clock_OnTick(object sender, TimeArgs args)
        {
            Console.WriteLine($"Current time:{args.Hour}:{args.Minute}:{args.Second}");
        }
        private void Clock_OnAlarm(object sender, TimeArgs args)
        {
            Console.WriteLine($"Clock is alarming! Time:{args.Hour}:{args.Minute}:{args.Second}");
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock(6, 30, 30);
            myClock.clock.SetAlarm(6, 30, 40);
            myClock.clock.Run();
        }
    }
}
