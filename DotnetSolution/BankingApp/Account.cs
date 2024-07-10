using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Account
    {
        public event  Operation overBalance;
        public event Operation underBalance;
        public double balance {  get; set; } 

        public void Withdraw(double amount)
        {
            double tempAmount = balance - amount;
            Monitor(tempAmount);
            balance = tempAmount;
        }
        public void Deposit(double amount)
        {
            double tempAmount = balance + amount;
            Monitor(tempAmount);
            balance = tempAmount;

        }
        public void Monitor(double amount)
        {
            if (amount < 10000)
            {
                //emit event
                //trigger event
                //raise an event
                underBalance();
               }
            else
            {
                 if(amount >= 250000)
                {
                    overBalance();
                }
            }
        }

    }
}
