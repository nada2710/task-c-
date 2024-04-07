using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    abstract class shape
    {
        public  abstract void calculatearea();
    }
     class rectangle : shape
    {
        public override void calculatearea()
        {
            int l, w;
            Console.WriteLine("area of rectangle:");
            Console.WriteLine("please enter length");
            l=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter width");
            w=int.Parse(Console.ReadLine());
            int area1 = l*w;
            Console.WriteLine($"area of rectagle = {area1}");



        }
    }
    class circle :shape
    {
        public override void calculatearea()
        {
            double pi = Math.PI;
            Console.WriteLine("area of circle:");
            Console.WriteLine("please enter redius");
            int r = int.Parse(Console.ReadLine());
            double area2 = pi*r*r;
            Console.WriteLine($"area of circle = {area2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape a1 = new rectangle();
            a1.calculatearea();
            shape a2 = new circle();
            a2.calculatearea();
        }
    }
}
