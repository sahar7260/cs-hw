using System;
using System.Collections.Generic;
using System.Text;

namespace assingment_3
{
    internal class VipAccount : Account
    {
        public VipAccount(int accountNumber, double balance) : base(accountNumber, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if ((balance - amount) < -5000)
            {
                Console.WriteLine("Your balance cannot go below -5,000");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"new balance: {balance}");
            }
        }

    }


}
