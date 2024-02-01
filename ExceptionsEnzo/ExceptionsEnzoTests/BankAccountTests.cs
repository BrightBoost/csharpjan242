using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExceptionsEnzo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace ExceptionsEnzo.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            BankAccount account = new BankAccount();
            account.Deposit(100);
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod()]
        public void DepositNegativeAmountTest()
        {
            BankAccount account = new BankAccount();
            try
            {
                account.Deposit(-100);
            }
            catch (InvalidDataException e)
            {
                StringAssert.Contains(e.Message, "Found invalid data while decoding");
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            BankAccount account = new BankAccount();
            account.MinBalance = -100;
            account.Withdraw(75);
            Assert.AreEqual(-75, account.Balance);
        }
    }
}