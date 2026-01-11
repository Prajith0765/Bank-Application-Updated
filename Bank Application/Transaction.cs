using BankApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Transaction
    {
        public string name; 
        public int Amount;
        public string message;
        public DateTime dateTime;

        //Constructor to initialize Transaction Details
        public Transaction(string name, string message, int amount)
        {
            this.name = name;
            this.message = message;
            this.Amount = amount;
            this.dateTime = DateTime.Now;
        } 

        
    }
}
