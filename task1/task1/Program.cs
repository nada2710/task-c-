using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("please enter num1");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter num2");
            num2=int.Parse(Console.ReadLine());
            int r = num1+num2;
            Console.WriteLine($"sum = {r}");
        }
    }
}
