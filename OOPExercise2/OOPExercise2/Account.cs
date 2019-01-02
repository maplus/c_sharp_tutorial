using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise2
{
    abstract class Account
    {
        private double balance;

        public Account()
        {
            balance = 0.00;
        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"A total of {amount.ToString("F")} has been deposited to your account.");
            Balance();
        }

        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"A total of {amount.ToString("F")} has been withdrawn from your accunt.");
            }
            else
                Console.WriteLine($"You do not have enough funds to withdraw that amount.");
        }

        public void Balance()
        {
            Console.WriteLine($"Your current balance is {balance.ToString("F")}.");
        }
    }
}
