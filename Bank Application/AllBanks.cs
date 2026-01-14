//using BankApplication;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bank_Application
//{

//    //enum Banks
//    //{
//    //    SBI,
//    //    HDFC,
//    //    KVB,
//    //    IOB,
//    //    UBI,
//    //}
//    internal class AllBanks
//    {
//        protected Dictionary<string, Bank> banksDictionary;

//        public AllBanks() 
//        {
//            banksDictionary = new Dictionary<string, Bank>
//        {
//            { "SBIN1001", new Bank("SBI") },
//            { "HDFC1002", new Bank("HDFC") },
//            { "KVB1003", new Bank("KVB") },
//            { "IOB1004", new Bank("IOB") },
//            { "UBI1005", new Bank("UBI") }
//        };

//        }


//        public Bank GetBank(string ifsc)
//        {
//            banksDictionary.TryGetValue(ifsc, out Bank bank);
//            return bank;
//        }
//    }
//}
