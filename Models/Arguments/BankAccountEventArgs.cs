using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Arguments
{
    public class BankAccountEventArgs : EventArgs
    {
        public decimal Amount { get; set; }
        public DateTime ActivityTime { get; set; }
    }
}
