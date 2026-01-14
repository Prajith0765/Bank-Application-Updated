

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace BankApplication
{
    internal class Bank
    {
        public string BankName;
        //A List to Store Customer Details
        protected List<Customer> customerList;
        public int accNumber = 1001;
        protected Dictionary<int, Customer> customerDictionary;



        //Constructor to allocate new List of Customers
        public Bank() 
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
        //Getter for the Name
        public string getName()
        {
            Console.WriteLine("Enter the user Name: ");
            return Console.ReadLine();
        }
        //Getter for the Age
        public byte getAge()
        {
            Console.WriteLine("Enter the user Age: ");
            return Convert.ToByte(Console.ReadLine());
        }
        //Getter for the Account Type
        public string getAccType()
        {
            Console.WriteLine("Enter the AccountType : ");
            return Console.ReadLine();
        }
        //Getter for the Mobile Number
        public long getMobileNumber()
        {
            Console.WriteLine("Enter the MobileNumber: ");
            return Convert.ToInt64(Console.ReadLine());
        }
        //Getter for the amount
        public int getAmount()
        {
            Console.WriteLine("Enter the Amount: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int getAccNumber()
        {
            Console.WriteLine("Enter Your Account Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}