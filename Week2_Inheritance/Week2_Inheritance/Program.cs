using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /* SavingsAccount mySavingsAccount = new SavingsAccount(); //created an instance if SavingsAccount. name of instance: mySavingsAccount

            mySavingsAccount.Balance = 1000;
            mySavingsAccount.InterestRate = 5;

            double interestInEuros = mySavingsAccount.CalculateInterest();
            */

            User myUser = new User();
            myUser.IdCard = "230875";
            myUser.Name = "Jake";
            myUser.Surname = "Abela";

            BankAccount b = new BankAccount("585858585858585858", 100, myUser);
            SavingsAccount s = new SavingsAccount("5858585858585858585", 100, myUser, 1.5);

            double updatedBalance = s.Withdraw(100);
        }
    }
}
