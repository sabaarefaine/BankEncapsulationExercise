using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        //A private field (similar to variable) of type double named balance with a value of 0
        private double balance = 0;
        //same for a password
        private string password = "password";

        
        public bool VerificationProcess()
        {
            Console.WriteLine("What is your password?");
            var answer = Console.ReadLine();

            if (answer == password)
            {
                return true;
            }
            else
                Console.WriteLine("Incorrect Password");

            return false;
        }
        //Define a method named Deposit that will accept a double and store that value in the balance field
        //Encapsulation in deposit method

        public void Deposit()
        {
            var verify = VerificationProcess();
            if (verify)
            {
                Console.WriteLine("How much do you want to deposit?");
                var deposit = int.Parse(Console.ReadLine());
                balance += deposit;
                Console.WriteLine($"Your balance is now ${balance}.");
            }
        }

        //Define a method named GetBalance that will return the amount stored in the balance field
        public void GetBalance()
        {
            var verify = VerificationProcess();
            if (verify)
            {
                Console.WriteLine(balance);
            }
            
        }

      

        public void Withdraw()
        {
            var verify = VerificationProcess();

            if (verify)
            {
                Console.WriteLine("How much do you want to withdraw?");
                var withdraw = int.Parse(Console.ReadLine());

                if (withdraw > balance)
                {
                    Console.WriteLine("Insufficient funds");
                }
                else
                {
                    balance -= withdraw;
                    Console.WriteLine($"Your balance is now ${balance}");
                }
            }

        }

    }
}
