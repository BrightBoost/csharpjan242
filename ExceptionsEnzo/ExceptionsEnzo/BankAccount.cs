using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsEnzo
{
    public class BankAccount
    {
        public BankAccount() { }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public decimal MinBalance { get; set; }

        public void Withdraw(decimal amount)
        {
            if(Balance - amount > MinBalance)
            {
                Balance = Balance - amount;
            }
        }

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new InvalidDataException();
            }
            Balance = Balance + amount;
        }

    }
}
