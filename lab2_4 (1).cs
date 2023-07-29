using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to convert in binary");
            long a = Convert.ToInt32(Console.ReadLine());
            long i;
            long ans = a % 2;
            a=a/2;
            while(a!=0){
                ans = ans * 10 + a % 2;
                    a = a / 2;
            }
            long binary = ans % 10;
            ans = ans / 10;
            while (ans > 0)
            {
                binary = binary * 10 + ans % 10;
                ans=ans/10;
            }
            Console.WriteLine("{0}", binary);    
        }
    }
}
