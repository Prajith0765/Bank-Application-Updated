using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankApplication
{
    //A self defined class for saving Customer Data
    internal class Customer
    {
        public string name;
        public byte age;
        public string accType;
        public long mobileNumber;
        public int balance;

        public List<Transaction> transactions;

        //Constructor to Store and Configure the Customer Datas
        public Customer(string name, byte age, string accType, long mobileNumber)
        {
            this.name = name;
            this.age = age;
            this.accType = accType;
            this.mobileNumber = mobileNumber;
            this.balance = 0;
            this.transactions = new List<Transaction>();
        }

        public void displayTransaction()
        {
            
            foreach(Transaction t in transactions)
            {
                Console.WriteLine($"{t.dateTime} - Action {t.message} :  {t.Amount}");
            }
        }
    }
}