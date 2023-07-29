using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Height in meters");
            Double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Weight in pounds");
            Double w = Convert.ToDouble(Console.ReadLine());
            h = h * 0.0254;
            w = w / 0.45359237;
            Double ans = w / (h * h);
            Console.WriteLine("Ans is : {0}",ans);

        }
    }
}
