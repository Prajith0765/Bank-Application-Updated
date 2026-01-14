using Bank_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_Application.Entity
{
    //A Class which inherits the Properties and Methods of the Bank Class
    internal class BankOperations : IBank
    {

        //Method to Find the Customer Details by Entering the Name
        public Customer customerValue;

        //public string BankName;
        //A List to Store Customer Details
        protected List<Customer> customerList;
        public int accNumber = 1001;
        protected Dictionary<int, Customer> customerDictionary;

        //Constructor to allocate new List of Customers
        public BankOperations()
        {
            customerList = new List<Customer>();
            customerDictionary = new Dictionary<int, Customer>();

        }

        //Method to Add Customer in the List
        public void addCustomer(Customer customer)
        {
            if (!customerList.Contains(customer))
            {

                customerList.Add(customer);

                customerDictionary.Add(accNumber, customer);
                // While Creating an account to the user it created a Transaction object to track their history
                Transaction transaction = new Transaction(
                    customer.name,
                    "Account Created",
                    customer.balance);
                customer.transactions.Add(transaction);

                Console.WriteLine("Account Created Successfully");
                Console.WriteLine("Your Account Number is : " + accNumber);
                accNumber++;

            }
            else
            {
                Console.WriteLine("Customer Already Exist as Account Number : " + accNumber);

            }
        }
        //Method to Remove Customer in the List
        public void removeCustomer(string name)
        {
            Customer customer = customerList.Find(c => c.name == name);
            customerDictionary.Remove(accNumber);
            if (customerList.Contains(customer))
            {
                customerList.Remove(customer);
            }
            else
            {
                Console.WriteLine("Customer Not Exist");

            }
        }

        public Customer findCustomer(int accNumber)
        {
            customerDictionary.TryGetValue(accNumber, out customerValue);
            return customerValue;
        }
        /*public Customer findCustomer(string name)
        //{
        //    return customerList.Find(c => c.name == name);
        } */
        //Method to DepositAmount to the Account by entering Holder name
        public void depositAmount(int accNumber, int amount)
        {
            //Searching and Getting the Exact Customer Details from the list
            Customer customer = findCustomer(accNumber);
            if (customer != null)
            {
                customer.balance += amount;
                Console.WriteLine("Deposit Amount : " + amount);
                Console.WriteLine("Your Current Balance: " + customer.balance);
                //Creating a Transaction Object for the customer to track their deposits
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
        public void withDrawalAmount(int accNumber, int amount)
        {
            //Searching and Getting the Exact Customer Details from the list
            Customer customer = findCustomer(accNumber);
            if (customer != null && customer.balance > amount)
            {
                customer.balance -= amount;
                Console.WriteLine("Withdrawal Amount : " + amount);
                Console.WriteLine("Your Current Balance: " + customer.balance);
                //Creating a Transaction Object for the customer to track their withdrawal
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
        public void displayDetails(int accNumber)
        {
            //Searching and Getting the Exact Customer Details from the list
            Customer customer = findCustomer(accNumber);
            if (customer != null)
            {
                Console.WriteLine("Account Holder Name: " + customer.name);
                Console.WriteLine("Account Holder Age: " + customer.age);
                Console.WriteLine("Account Type: " + customer.accType);
                Console.WriteLine("Account Balance: " + customer.balance);
                customer.displayTransaction();
            }
        }
        //Printing the customer ist to view the customers in the bank 
        //public void printCustomerList(Customer customer)
        //{
        //    foreach (var cust in customerList)
        //    {
        //        Console.WriteLine("Customer Name: " + cust.name);
        //    }
        //}



    }
}