using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4
{
    class Distance
    {
        public Double dist1;
        public Double dist2;
        public Double dist3;
        

        public Distance()
        {

            Console.WriteLine("enter dist1:");
            dist1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter dist2:");
            dist2 = Convert.ToDouble(Console.ReadLine());
            dist3 = dist1 + dist2 ;

        }
        public void display()
        {
            Console.WriteLine("dist3: " + dist3);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Distance b = new Distance();
            b.display();
            Console.ReadLine();
        }
    }
}
