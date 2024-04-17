using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class CreditManager
    {
        private List<Credit> credits;
        public CreditManager()
        {
            credits = new List<Credit>();
        }

        public void AddCredit(Credit credit)
        {
            credits.Add(credit);
        }
        public Credit FindCreditByBankName(string bankName)
        {
            foreach (var credit in credits)
            {                
                if (credit.BankName == bankName)
                    return credit;
            }
            return null;
        }

        public void ShowAllCredits()
        {
            Console.WriteLine("Можливi кредити: ");
            foreach (var credit in credits)
            {
                Console.WriteLine($"Банк: {credit.BankName}, Вiдсоткова ставка: {credit.InterestRate}, " +
                              $"Термiн кредиту: {credit.LoanTerm} мiсяцiв, Сума кредиту: {credit.LoanAmount}");               
            }
        }


    }
}
