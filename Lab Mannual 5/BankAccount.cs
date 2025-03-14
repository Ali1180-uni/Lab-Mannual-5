using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Mannual_5
{
    internal class BankAccount
    {
        private string AccountNumber;
        private string AccountHolderName;
        private double balance;

        public BankAccount(string accountNumber, string accountHolderName, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            this.balance = balance;
        }
        public BankAccount(BankAccount new1)
        {
            this.AccountNumber = new1.AccountNumber;
            this.AccountHolderName = new1.AccountHolderName;
            this.balance=new1.balance;
        }

        public void deposit(double amount)
        {
            balance += amount;
        }

        public void withdraw(double amount)
        {
            if(balance > 0)
            {
                balance -= amount;
            }
        }
        public void displaybalance()
        {
            if(balance < 0)
            {
                Console.WriteLine("Not Enough Money");
            }
            else
            {
                Console.WriteLine($"The Current Balance is: {balance}");
            }
        }
    }
}
