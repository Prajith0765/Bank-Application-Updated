using Bank_Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Banks
{
    internal class IOBBank : BankOperations
    {
        public IOBBank() { }

        // Optional: expose a GetInstance that uses the singleton helper
        public static IOBBank GetInstance()
        {
            return Singleton<IOBBank>.GetInstance();
        }
    }
}
