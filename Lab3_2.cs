using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class staff
    {
       public String Name;
        public String Department;
        public String Designation;
       public String Experience;
         public Double Salary;

        public void getData()
        {
            Console.WriteLine("enter name:");
            Name = Console.ReadLine();
            Console.WriteLine("enter Department:");
            Department = Console.ReadLine();
            Console.WriteLine("enter Designation:");
            Designation = Console.ReadLine();
            Console.WriteLine("enter Experience:");
            Experience = Console.ReadLine();
            Console.WriteLine("enter Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
            
        }
        public void display()
        {
            Console.WriteLine("Name"+Name);
            Console.WriteLine("Salary" + Salary);
        }
    }
    class Program
    {
         static void Main(string[] args)
        {
           staff[] s=new staff[5];
         
           
            for (int i = 0; i < 2; i++)
            {
                s[i] = new staff();
                s[i].getData();
            }
            for (int j = 0; j < 2; j++)
            {
                if (s[j].Designation == "HOD")
                {
                    s[j].display();
                    
                }
            }
            Console.ReadLine();
        }
    }
}
