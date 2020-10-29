using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{

    public enum AccountStatus { Active, Suspended, Frozen, Disabled, Closed }
    class BankAccount
    {

        /// <summary>
        /// can create more than 1 constructor in a class
        /// default constructor (is usually also parameterless constructor
        /// </summary>
        public BankAccount()
        {
            Balance = 0;
            OpeningDate = DateTime.Now;
        }

        /// <summary>
        /// 2nd constructor with parameters
        /// </summary>

        public BankAccount(string iban, double balance, User owner) : this()
        {
            OpeningDate = DateTime.Now;
            Iban = iban;
            Balance = balance;
            Owner = owner;
        }

        public string Iban { get; set; }
        protected double Balance { get; set; } //if you want to allow access to this property, ONLY from inherited classes

        public User Owner { get; set; }
        public DateTime OpeningDate { get; }
        public DateTime? ClosingDate { get; set; } //value stored inside this property /field can also be null

        public AccountStatus Status { get; set; }

        public double Withdraw (double amount) {
            //log the withdrawal transaction
            if (amount <= Balance)
                Balance -= amount;
            return Balance;
        }
        public double Deposit (double amount) {
            Balance += amount;
            return Balance;
        }

    }
}
