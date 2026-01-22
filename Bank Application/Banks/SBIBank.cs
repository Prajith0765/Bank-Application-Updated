using Bank_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Banks
{
    internal class SBIBank : BankOperations
    {
        public SBIBank() { }

        // Optional: expose a GetInstance that uses the singleton helper
        public static SBIBank GetInstance()
        {
            return Singleton<SBIBank>.GetInstance();
        }
    }
}
