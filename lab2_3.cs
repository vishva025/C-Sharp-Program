using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            for(int i=0;i<=4;i++){
                 Console.WriteLine("Enter the Marks");
                 int s1 = Convert.ToInt32(Console.ReadLine());
                 ans = ans + s1;
            }
            ans = ans / 5;
            if (ans < 40)
            {
                Console.WriteLine("Sorry , YOu are failed : {0} ",ans);
            }
            else if(ans<=49){
                 Console.WriteLine("YOu are in third devision : {0} ",ans);
            }
            else if (ans <= 59)
            {
                Console.WriteLine("YOu are in Second devision : {0} ", ans);
            }
            else if (ans >=60)
            {
                Console.WriteLine("YOu are in First devision : {0} ", ans);
            }
            else
            {
                Console.WriteLine("ENter valid inputs");
            }
     

        }
    }
}
