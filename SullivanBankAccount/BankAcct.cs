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
    class BankAcct
    {
        public BankAcct() : this("TBD", 0, 0.0M)
        {

        }
        public BankAcct(string name, int acctNum, decimal balance)
        {
            Name = name;
            AcctNum = acctNum;
            Balance = balance;
        }
        private string name;
        private int acctNum;
        private decimal balance;
        public string Name { get; set; }
        public int AcctNum { get; set;}
        public decimal Balance { get; set; }

        public virtual void Deposit(decimal amount)
        {
            //Add deposit amount to balance
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            //Check if amount will overdraw the account balance
            if (amount > Balance)
            {
                //if so,
                throw new InsufficientFundsException();
            }
            else
            {
                //Subtract withdrawal amount from balance
                Balance -= amount;
            }
        }
        public override string ToString()
        {
            return Name + " " + AcctNum + " " + Balance.ToString("C");
        }
    }
}
