using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class rectangle
    {
        public int length,width;
        public void area()
        {
            int a = length*width;
            Console.WriteLine($"area = {a}");
        }
        public void perimeter()
        {
            int p = (length+width)*2;
            Console.WriteLine($"perimeter = {p}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rec1 = new rectangle();
            Console.WriteLine("please enter width ");
            rec1.width=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter length ");
            rec1.length=int.Parse(Console.ReadLine());
            rec1.area();
            rec1.perimeter();
        }
    }
}
