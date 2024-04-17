using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class FlexibleCredit : Credit
    {
        public double EarlyRepayment { get; set; }
        public FlexibleCredit(string bankName, double interestRate, int loanTerm, double loanAmount, double earlyRepayment)
            : base (bankName, interestRate, loanTerm, loanAmount)
        {
            EarlyRepayment = earlyRepayment;
        }
        
        public new double TotalRepayment()
        {
            return base.TotalRepayment() + EarlyRepayment;
        }

    }
}
