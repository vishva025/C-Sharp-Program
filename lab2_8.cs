using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of r");
            int r = Convert.ToInt32(Console.ReadLine());
            double ans = 1;
            for (int i = 2; i <= n; i++)
            {
                ans = ans * i;
            }
            for (int i = 2; i <= n - r; i++)
            {
                ans = ans / i;
            }
            Console.WriteLine("Ans is : {0}", ans);
        }
    }
}
