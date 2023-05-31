using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_Operator_Overloading
{
    public class BankAccount
    {
        private double cash;
        private string owner;

        public BankAccount(double cash, string owner)
        {
            this.cash = cash;
            this.owner = owner;
        }

        public double Cash
        {
            get
            {
                return cash;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
        }

        public static BankAccount operator + (BankAccount bank1, BankAccount bank2 )
        {
            double newCash = bank1.Cash + bank2.Cash;
            string newOwner = bank1.Owner + "+" + bank2.Owner;

            BankAccount newBankAccount = new BankAccount( newCash, newOwner);
            return newBankAccount;
        }
       
    }
}
