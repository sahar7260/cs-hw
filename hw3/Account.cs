using System;
using System.Collections.Generic;
using System.Text;

namespace assingment_3
{
    internal class Account
    {
        protected int accountNumber;
        protected double balance;

        public Account (int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount>balance)
            {
                Console.WriteLine("there is not enough money");
            }
            else
            {
               balance-= amount;
                Console.WriteLine($"new balance: {balance}");
            }
        }
    }
}
