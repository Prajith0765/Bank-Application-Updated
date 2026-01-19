using Bank_Application.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class AssignInstance
    {
        public static IBank GetBank(BankEnum bank)
        {
            switch (bank)
            {
                case BankEnum.SBI:
                    return SBIBank.GetInstance();

                case BankEnum.HDFC:
                    return HDFCBank.GetInstance();

                case BankEnum.KVB:
                    return KVBBank.GetInstance();

                case BankEnum.IOB:
                    return IOBBank.GetInstance();

                case BankEnum.UBI:
                    return UBIBank.GetInstance();

                default:
                    throw new Exception("Invalid Bank Selection");
            }
        }
    }
