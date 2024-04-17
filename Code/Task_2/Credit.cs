using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Credit
    {
        public string BankName { get; set; }
        public double InterestRate { get; set; } //Відсоткова ставка
        public int LoanTerm { get; set; } //Строк кредиту
        public double LoanAmount { get; set; } //Розмір кредиту
        public Credit(string bankName, double interestRate, int loanTerm, double loanAmount) 
        { 
            BankName = bankName;
            InterestRate = interestRate;
            LoanTerm = loanTerm;
            LoanAmount = loanAmount;
        }

        public double TotalRepayment() 
        {
            double MonthRepayment = InterestRate / 12;
            double totalRepayment = LoanAmount * (MonthRepayment* Math.Pow(1 + MonthRepayment, LoanTerm)) / (Math.Pow(1 + MonthRepayment, LoanTerm) - 1);
            return totalRepayment;
        }
    }
}
