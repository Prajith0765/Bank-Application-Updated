using BankApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{

    enum Banks
    {
        SBI,
        HDFC,
        KVB,
        IOB,
        UBI,
    }
    internal class AllBanks
    {
        protected Dictionary<string, Bank> banksDictionary;

        public AllBanks() 
        {
            banksDictionary = new Dictionary<string, Bank>
        {
            { "SBIN1001", new Bank() },
            { "HDFC1002", new Bank() },
            { "KVB1003", new Bank() },
            { "IOB1004", new Bank() },
            { "UBI1005", new Bank() }
        };

        }


        public Bank GetBank(string ifsc)
        {
            banksDictionary.TryGetValue(ifsc, out Bank bank);
            return bank;
        }
    }
}
