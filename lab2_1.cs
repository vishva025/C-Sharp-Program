using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class lab2_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operation");
            string op = Console.Read();
            int ans;
            switch (op)
            {
                case "+":
                    {
                      ans=a+b;
                      Console.WriteLine("Ans is {0}",ans);
                      break;
                    }
                case "-":
                    {
                      ans=a-b;
                      Console.WriteLine("Ans is {0}",ans);
                      break;
                    }
                 case "/":
                    {
                      ans=a/b;
                      Console.WriteLine("Ans is {0}",ans);
                      break;
                    }
                 case "*" :
                    {
                      ans=a*b;
                      Console.WriteLine("Ans is {0}",ans);
                      break;
                    }

            }
            Console.ReadLine();


        }
    }
}
