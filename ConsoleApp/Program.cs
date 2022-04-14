// See https://aka.ms/new-console-template for more information
using Handlers;
using Models;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new SavingBankAccount()
            {
                Title = "Salman Taj"
            };


            // Adding subscribers to the event
            account.OnPaying += new EmailNotification().Notify;
            account.OnPaying += new SmsNotification().Notify;


            account.OnPaid += new SmsNotification().Notify;


            account.PayIn(1000);
            Console.WriteLine(account);
        }
    }
}
