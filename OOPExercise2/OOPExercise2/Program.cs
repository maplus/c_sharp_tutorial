using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccount = new CheckingAccount();
            SavingsAccount savingsAccount = new SavingsAccount();

            byte accountSelection;
            byte actionSelection;

            do
            {
                Console.WriteLine("Welcome, please make a selection:");
                Console.WriteLine("1 - Checking account");
                Console.WriteLine("2 - Savings account");
                Console.WriteLine("3 - Exit");
                accountSelection = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                if (accountSelection != 3)
                {
                    do
                    {
                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdraw");
                        Console.WriteLine("3 - Check balance");
                        Console.WriteLine("4 - Exit");
                        actionSelection = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();

                        switch (actionSelection)
                        {
                            case 1:
                                Console.Write("Enter the amount to deposit: ");
                                if (accountSelection == 1)
                                    checkingAccount.Deposit(Convert.ToDouble(Console.ReadLine()));
                                else if (accountSelection == 2)
                                    savingsAccount.Deposit(Convert.ToDouble(Console.ReadLine()));
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.Write("Enter the amount to withdraw: ");
                                if (accountSelection == 1)
                                    checkingAccount.Withdraw(Convert.ToDouble(Console.ReadLine()));
                                else if (accountSelection == 2)
                                    savingsAccount.Withdraw(Convert.ToDouble(Console.ReadLine()));
                                Console.WriteLine();
                                break;
                            case 3:
                                if (accountSelection == 1)
                                    checkingAccount.Balance();
                                else if (accountSelection == 2)
                                    savingsAccount.Balance();
                                Console.WriteLine();
                                break;
                        }
                    } while (actionSelection != 4);
                }
            } while (accountSelection != 3);
        }
    }
}
