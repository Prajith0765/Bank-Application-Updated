using Bank_Application;
using BankApplication;

public class Program
{
    public static void Main(string[] args)
    {
        //Bank bank = new Bank();
        Customer customer;
        AllBanks allBanks = new AllBanks();
        BankOperations bankOps = new BankOperations();

        Console.WriteLine("Enter IFSC:");
        string ifsc = Console.ReadLine();

        Bank bank = allBanks.GetBank(ifsc);

        if (!bankOps.SetBank(bank))
        {
            Console.WriteLine("Invalid IFSC Code");
            return;
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
                    bank.addCustomer(new Customer(bank.getName(), bank.getAge(),
                        bank.getAccType(), bank.getMobileNumber()));
                    break;
                //Removing Already existed user account
                case 2:
                    bank.removeCustomer(bank.getName());
                    break;
                //Depositing Amount in the user Account
                case 3:
                    bank.depositAmount(bank.getAccNumber(), bank.getAmount());
                    break;
                //Withdrawal of Amount from the user Account
                case 4:
                    bank.withDrawalAmount(bank.getAccNumber(), bank.getAmount());
                    break;
                //Displaying the user Account Details
                case 5:
                    bank.displayDetails(bank.getAccNumber());
                    break;
                //Exiting from the loop
                case 6: 
                    return;

            }
        goto Starting;
        //}
    }
}