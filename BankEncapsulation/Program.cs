using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the BankAccount class
            var newAccount = new BankAccount();

            //Allow the user of the application to Deposit money (plus other things)
            string userSelection;
            do
            {
                Console.WriteLine("What would you like to do today?\n" +
                    "Deposit \n" +
                    "Withdraw \n" +
                    "Check Balance \n" +
                    "Exit");
                userSelection = Console.ReadLine().ToLower();

                //switch case to allow user to make atm selection
                switch (userSelection)
                {
                    case ("deposit"):
                        newAccount.Deposit();
                        break;
                    case ("withdraw"):
                        newAccount.Withdraw();
                        break;
                    case ("check balance"):
                        newAccount.GetBalance();
                        break;
                    case ("exit"):
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
                } while (userSelection != "exit");


            }

        }

}
