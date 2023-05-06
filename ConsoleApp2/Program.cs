using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triad t1 = new Triad(1, 2, 3);
            Triad t2 = new Triad(1, 2, 4);
            Triad t3 = new Triad(1, 3, 2);

            Console.WriteLine(t1.CompareTo(t2));
            Console.WriteLine(t1.CompareTo(t3));
            Console.WriteLine(t2.CompareTo(t3));

            Triad t4 = new Triad(0, 0, 0);
            t4.Read();
            t4.Display();

            Time time1 = new Time(1, 2, 3);
            Time time2 = new Time(1, 2, 4);
            Time time3 = new Time(1, 3, 2);

            Console.WriteLine(time1.CompareTo(time2));
            Console.WriteLine(time1.CompareTo(time3));
            Console.WriteLine(time2.CompareTo(time3));

            Time time4 = new Time(0, 0, 0);
            time4.Read();
            time4.Display();
        }
    }
    

    

}
