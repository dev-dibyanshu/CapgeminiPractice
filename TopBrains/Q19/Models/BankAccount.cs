using System;
using System.Collections.Generic;
using System.Text;

namespace Q19.Models
{
    internal class BankAccount
    {
        public int Balance {  get; set; }
        public int[] Transactions { get; set; } = [];
    }
}
