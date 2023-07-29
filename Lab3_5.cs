using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4
{
    class Salary
    {
        public Double Basic;
        public Double TA;
        public Double DA=2000;
        public Double HRA=2100;
        public Double salary;

        public Salary()
        {
           
            Console.WriteLine("enter Basic:");
             Basic= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter TA:");
            TA = Convert.ToDouble(Console.ReadLine());
            salary = Basic + TA + DA + HRA;

        }
        public void display()
        {
            Console.WriteLine("Salary: " + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Salary b = new Salary();
            b.display();
            Console.ReadLine();
        }
    }
}
