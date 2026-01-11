using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankApplication
{
    //A Class which inherits the Properties and Methods of the Bank Class
    internal class BankOperations : Bank
    {
        //Method to Find the Customer Details by Entering the Name
        public Customer findCustomer(string name)
        {
            return customerList.Find(c => c.name == name);
        }
        //Method to DepositAmount to the Account by entering Holder name
        public void depositAmount(string name, int amount)
        {
            //Searching and Getting the Exact Customer Details from the list
            Customer customer = findCustomer(name);
            if (customer != null)
            {
                customer.balance += amount;
                Console.WriteLine("Deposit Amount : " + amount);
                Console.WriteLine("Your Current Balance: " + customer.balance);

                Transaction transaction = new Transaction(
                    customer.name,
                    "Amount Deposited",
                    amount);
                customer.transactions.Add(transaction);
            }
            else
            {
                Console.WriteLine("Account Not Found");
            }

        }
        //Method to WithDraw Amount to the Account by entering Holder name
        public void withDrawalAmount(string name, int amount)
        {
            //Searching and Getting the Exact Customer Details from the list
            Customer customer = findCustomer(name);
            if (customer != null && customer.balance > amount)
            {
                customer.balance -= amount;
                Console.WriteLine("Withdrawal Amount : " + amount);
                Console.WriteLine("Your Current Balance: " + customer.balance);
                Transaction transaction = new Transaction(
                    customer.name,
                    "Amount Withdrawn",
                    amount);
                customer.transactions.Add(transaction);
            }
            else
            {
                Console.WriteLine("Account Not Found");
            }
        }
        //Searching and Display the Exact Customer Details from the list
        public void displayDetails(string name)
        {
            //Searching and Getting the Exact Customer Details from the list
            Customer customer = findCustomer(name);
            if (customer != null)
            {
                Console.WriteLine("Account Holder Name: " + customer.name);
                Console.WriteLine("Account Holder Age: " + customer.age);
                Console.WriteLine("Account Type: " + customer.accType);
                Console.WriteLine("Account Balance: " + customer.balance);
                customer.displayTransaction();
            }
        }

        public void printCustomerList(Customer customer)
        {
            foreach (var cust in customerList)
            {
                Console.WriteLine("Customer Name: " + cust.name);
            }
        }



    }
}