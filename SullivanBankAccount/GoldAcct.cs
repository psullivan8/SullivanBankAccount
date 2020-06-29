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
    class GoldAcct:SilverAcct
    {
        public GoldAcct()
        {

        }
        public GoldAcct(string name, int acctNum, decimal balance, int atmAccount, int pin, double interest)
    : base(name, acctNum, balance, atmAccount, pin)
        {
            Interest = interest;
        }
        private double interest;
        public double Interest { get; set; }
        public override void Deposit(decimal amount)
        {
            //Read in amount
            if (Balance < 1000M)
            {
                //Deduct $1.00 if balance is less than $1,000.00
                //The fee is based on the balance prior to the deposit
                amount -= 1.00M;
                Balance += amount;
            }
            else if(Balance > 5000M)
            {
                Balance += Balance * (decimal)Interest/100;
                Balance += amount;
            }
        }
        public override void Withdraw(decimal amount)
        {
            //Read in amount
            //If balance is less than $20,000
            //Add $2.50 as bank fee for withdrawal
            //Fees not charged if balance is $20,000 or more
            if(Balance < 20000M)
            {
                //Now we have a new amount += 2.50M
                amount += 2.50M;
                Balance -= amount;
            }
            //Check if the amount will overdraw the account
            else if (amount > Balance)
            {
                //if so, 
                throw new InsufficientFundsException();
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Investment";
        }
    }
}
