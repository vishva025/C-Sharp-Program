using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            Int64 a = Convert.ToInt64(Console.Read());
            if (a % 4 == 0)
            {
                Console.WriteLine("leap year");
            }
            else if (a % 400 == 0 && a % 100 != 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("Not aleap year");
            }

        }
    }
}
