using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0.0;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public double CheckBalance()
        {
            return balance;
        }
    }

}
