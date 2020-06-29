//Patrik Sullivan psullivan8@cnm.edu
//SullivanBankAccount
//6-25-20

using System;
using System.Collections.Generic;
using System.Text;

namespace SullivanBankAccount
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Insufficient Funds!")
        {

        }
    }
}
