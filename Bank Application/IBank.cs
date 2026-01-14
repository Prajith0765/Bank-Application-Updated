using Bank_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal interface IBank
    {
        public void addCustomer(Customer customer);
        public void removeCustomer(string name);
        public void depositAmount(int accNumber, int amount);
        public void withDrawalAmount(int accNumber, int amount);
        public void displayDetails(int accNumber);

    }
}
