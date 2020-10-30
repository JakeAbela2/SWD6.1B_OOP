using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    //inheretance: that the class in question is inhereting/ getting all the public OR protected members of the base class.
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string iban, double balance, User owner, double interestRate) : base(iban, balance, owner)
        {
            InterestRate = interestRate;
        }
        public double InterestRate { get; set; }

        /// <summary>
        /// Basically this calculates the end balance of the year according the interest rate set
        /// </summary>
        /// <returns>It returns the actual interest</returns>
        public double CalculateInterest()
        {
            return Balance * (InterestRate / 100);
        }

    }
}

 