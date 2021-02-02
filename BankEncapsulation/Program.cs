using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();
            Console.WriteLine("Please enter your deposit amount ");

            var amountTODeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountTODeposit);

            Console.WriteLine($"Your blance is {account.GetBlance()}");

            




          







        }
    }
}
