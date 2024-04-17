using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            CreditManager creditManager = new CreditManager();

            creditManager.AddCredit(new Credit("Mono", 34.8, 9, 35000));
            creditManager.AddCredit(new FlexibleCredit("Privat", 16.5, 6, 135000, 500));

            creditManager.ShowAllCredits();

            Console.WriteLine("\nВведiть назву банку:");
            string bankNameToFind = Console.ReadLine();


            Credit foundCredit = creditManager.FindCreditByBankName(bankNameToFind);
            if (foundCredit != null)
            {
                Console.WriteLine($"\nКредит у банку {bankNameToFind}:\n" +
                    $"Вiдсоткова ставка: {foundCredit.InterestRate}, " +
                    $"Термiн кредиту: {foundCredit.LoanTerm} мiсяцiв, Сума кредиту: {foundCredit.LoanAmount}");

                Console.WriteLine($"\nСума погашення для кредита в '{foundCredit.BankName}': {foundCredit.TotalRepayment()}"); //

                if (foundCredit is FlexibleCredit flexibleCredit)
                {
                    double repayment = flexibleCredit.TotalRepayment();
                    Console.WriteLine($"Штраф за дострокове погашення: {flexibleCredit.EarlyRepayment}");
                    Console.WriteLine($"Сума погашення для кредита в '{foundCredit.BankName}': {repayment}"); //
                }
            }
            else
                Console.WriteLine($"\nКредит не знайдений для {bankNameToFind}");

            Console.ReadKey();
        }
    }
}