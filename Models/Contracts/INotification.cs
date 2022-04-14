using Models.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface INotification
    {
        void Notify(object source, BankAccountEventArgs e);
    }
}
