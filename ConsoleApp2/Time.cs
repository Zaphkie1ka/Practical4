using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        public int CompareTo(Time other)
        {
            if (this.hour != other.hour)
            {
                return this.hour.CompareTo(other.hour);
            }
            else if (this.minute != other.minute)
            {
                return this.minute.CompareTo(other.minute);
            }
            else
            {
                return this.second.CompareTo(other.second);
            }
        }

        public void Read()
        {
            Console.Write("Enter hour: ");
            this.hour = int.Parse(Console.ReadLine());

            Console.Write("Enter minute: ");
            this.minute = int.Parse(Console.ReadLine());

            Console.Write("Enter second: ");
            this.second = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("{0:00}:{1:00}:{2:00}", hour, minute, second);
        }
    }
}
