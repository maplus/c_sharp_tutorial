using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise2
{
    class SavingsAccount : Account
    {
        public override void Deposit(double amount)
        {
            double bonus = Math.Floor(amount / 100);
            if (bonus > 0)
                Console.WriteLine($"You have earned {bonus} of bonus bucks.");
            base.Deposit(amount + bonus);
        }
    }
}
