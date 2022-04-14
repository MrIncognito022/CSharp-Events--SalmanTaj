using Models.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SmsNotification : INotification
    {
        public void Notify(object source, BankAccountEventArgs e)
        {
            //TODO: Send Email
            Console.WriteLine($"SMS: Amount {e.Amount} at time {e.ActivityTime.ToString("dd MMM yyyy HH:mm:ss")}");

        }
    }
}
