using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Triad
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public Triad(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Read()
        {
            Console.Write("Enter X value: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Enter Y value: ");
            Y = int.Parse(Console.ReadLine());
            Console.Write("Enter Z value: ");
            Z = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}");
        }

        public int CompareTo(Triad other)
        {
            if (other == null)
            {
                return 1;
            }

            if (X != other.X)
            {
                return X - other.X;
            }

            if (Y != other.Y)
            {
                return Y - other.Y;
            }

            return Z - other.Z;
        }
    }
}
