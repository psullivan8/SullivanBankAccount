//Patrik Sullivan psullivan8@cnm.edu
//SullivanBankAccount
//6-25-20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SullivanBankAccount
{
    class SilverAcct:BankAcct
    {
        private int atmAccount;
        private int pin;
        public SilverAcct():base()
        {
            ATMAccount = 1;
            PIN = 1234;
        }
        public SilverAcct(string name, int acctNum, decimal balance, int atmAccount, int pin)
            : base(name, acctNum, balance)
        {
            ATMAccount = atmAccount;
            PIN = pin;
        }

        public int ATMAccount { get; set; }
        public int PIN { get; set; }
        public override void Deposit(decimal amount)
        {
            //Read in amount
            //Deduct $1.00 if balance is less than $1,000.00
            if(Balance < 1000M)
            {
                amount -= 1.00M;
            }
            //The fee is based on the balance prior to the deposit
            //Add deposit amount to balance
            //TODO:  Now use the base class functionality
            base.Deposit(amount);
            //Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            //Read in amount
            //Add $2.50 as bank fee for withdrawal
            //Now we have a new amount += 2.50M
            amount += 2.50M;
            //TODO:  Now use the base class functionality
            base.Withdraw(amount);
            //Check if the balance will overdraw the account
            //if (amount > Balance)
            //{
            //    //if so, 
            //    throw new InsufficientFundsException();
            //}
            //else
            //{
            //    base.Withdraw(amount);
            //}
        }

        public override string ToString()
        {
            return base.ToString() + " ATM: " + ATMAccount;
        }
    }
}
