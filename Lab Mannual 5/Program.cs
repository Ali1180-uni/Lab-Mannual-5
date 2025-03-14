using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_Mannual_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\t------------------");
                Console.WriteLine("\t||     MENU     ||");
                Console.WriteLine("\t------------------");
                Console.WriteLine("Please Select Option (1-17) or Press 0 to Exit:");
                int sel;
                try
                {
                    sel = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input! Please enter a number.");
                    continue;
                }
                if (sel == 0)
                {
                    Console.WriteLine("Exited!");
                    break;
                }
                switch (sel)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Option 1 selected.");
                        Person x1 = new Person("Ali", 18);
                        x1.displaydetails();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Option 2 selected.");
                        Person x2 = new Person("Ali", 18);
                        x2.IsAdult();
                        x2.CelebrateBirthday();
                        x2.displaydetails();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Option 3 selected.");
                        Person one = new Person("Ali", 18);
                        one.IsAdult();
                        one.CelebrateBirthday();
                        one.displaydetails();
                        Person x3 = new Person(one);
                        x3.IsAdult();
                        x3.CelebrateBirthday();
                        x3.displaydetails();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Option 4 selected.");
                        BankAccount u1 = new BankAccount("Ali1180", "Ali", 2000);
                        Console.WriteLine("Enter the Money to Deposit: ");
                        double num=Convert.ToDouble(Console.ReadLine());
                        u1.deposit(num);
                        Console.WriteLine("Enter the Money to WithDraw: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        u1.withdraw(num1);
                        u1.displaybalance();
                        Console.WriteLine("Data Of Copy Constructor");
                        BankAccount u2 = new BankAccount(u1);
                        u2.displaybalance();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Option 5 selected.");
                        
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Option 6 selected.");
                        
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input! Please enter a number between 0-17.");
                        break;
                }

            }
        }
    }
}
