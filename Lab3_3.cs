using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    class Bank_Account
    {
        public int Account_No;
        public String Email;
        public String User_Name;
        public String Account_Type;
        public Double Account_Balance;

        public void getData()
        {
            Console.WriteLine("enter Account_No:");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Email:");
            Email = Console.ReadLine();
            Console.WriteLine("enter User_Name:");
            User_Name = Console.ReadLine();
            Console.WriteLine("enter Account_Type:");
            Account_Type = Console.ReadLine();
            Console.WriteLine("enter Account_Balance:");
            Account_Balance = Convert.ToDouble(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Account_No" + Account_No);
            Console.WriteLine("Email" + Email);
            Console.WriteLine("User_Name" + User_Name);
            Console.WriteLine("Account_Type" + Account_Type);
            Console.WriteLine("Account_Balance" + Account_Balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank_Account b = new Bank_Account();
            b.getData();
            b.display();
            Console.ReadLine();
        }    }
}
