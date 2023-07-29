using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4
{
    class Student
    {
        public int Enrollment_No;
        public String Student_Name;
        public int Semester;
        public Double CPI;
        public Double SPI;

        public  Student()
        {
            Console.WriteLine("enter Enrollment_No:");
            Enrollment_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Student_Name:");
            Student_Name = Console.ReadLine();
            Console.WriteLine("enter Semester:");
            Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter CPI:");
            CPI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter SPI:");
            SPI = Convert.ToDouble(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Enrollment_No" + Enrollment_No);
            Console.WriteLine("Student_Name" + Student_Name);
            Console.WriteLine("Semester" + Semester);
            Console.WriteLine("CPI" + CPI);
            Console.WriteLine("SPI" + SPI);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student b = new Student();
            b.display();
            Console.ReadLine();
        }
    }
}
