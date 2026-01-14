//using BankApplication;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bank_Application
//{
//    internal class AssignOperations
//    {
//        public static AssignOperations GetInstance(BanksEnum bankName)
//        {
//            IBank instance = null;
//            switch (bankName)
//            {
//                case BanksEnum.SBI:
//                    instance = new SBIBank();
//                    break;

//                case BanksEnum.CBL:
//                    instance = new CBI();
//                    break;

//                default:
//                    throw new ArgumentException("Invalid bank name");
//            }

//            return instance;
//        }
//    }
//}
