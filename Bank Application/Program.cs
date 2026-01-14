using Bank_Application.Entity;
using Bank_Application;
using Bank_Application.Banks;

public class Program
{
    public static void Main(string[] args)
    {
        GetSet bankOP;
        Customer customer;
        IBank instance;
        BankOperations bank = new BankOperations();
        GetSet getSet = new GetSet();
        
        string[] banks = Enum.GetNames(typeof(BankEnum));
        for (int i = 0; i < banks.Length; i++)
        {
            Console.WriteLine($"{i + 1}). {banks[i]}");
        }
        Console.WriteLine("Select Your Bank: ");
        byte opt = 0;
        Byte.TryParse(Console.ReadLine(), out opt);
        BankEnum selectedBank = (BankEnum)opt;
        Console.WriteLine("=======================================================");
        Console.WriteLine("Welcome to " + selectedBank.ToString() + " Bank");

    BankSelection:
        switch (selectedBank)
        {
            case BankEnum.SBI:
                new SBIBank();
                break;

            case BankEnum.HDFC:
                new HDFCBank();
                break;
            case BankEnum.KVB:
                new KVBBank();
                break;
            case BankEnum.IOB:
                new IOBBank();
                break;
            case BankEnum.UBI:
                new UBIBank(); 
                break;

        }



    //For Loop for Iterative Getting user Options
    //while (true)
    //{
    Starting:
        Console.WriteLine("WELCOME TO BANKING APPLICATION");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Deposit Amount");
            Console.WriteLine("4. Withdraw Amount");
            Console.WriteLine("5. Display Account Details");
            Console.WriteLine("6.Exit...");
            //Byte where the user option is stored
            byte option = Convert.ToByte(Console.ReadLine());

            switch (option)
            {
                //Creating User Account in a Bank
                case 1:
                    bank.addCustomer(new Customer(getSet.getName(), getSet.getAge(),
                        getSet.getAccType(), getSet.getMobileNumber()));
                    break;
                //Removing Already existed user account
                case 2:
                    bank.removeCustomer(getSet.getName());
                    break;
                //Depositing Amount in the user Account
                case 3:
                    bank.depositAmount(getSet.getAccNumber(), getSet.getAmount());
                    break;
                //Withdrawal of Amount from the user Account
                case 4:
                    bank.withDrawalAmount(getSet.getAccNumber(), getSet.getAmount());
                    break;
                //Displaying the user Account Details
                case 5:
                    bank.displayDetails(getSet.getAccNumber());
                    break;
                //Exiting from the loop
                case 6: 
                    return;

            }
        goto Starting;
        //}
    }
}