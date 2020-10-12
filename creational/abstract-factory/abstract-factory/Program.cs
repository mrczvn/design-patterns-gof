using abstract_factory.Domain.Entities.Base;
using abstract_factory.Factories;
using System;

namespace abstract_factory
{
    internal class Program
    {
        private static void Main()
        {
            var bankFactory = FactoryCreator.getAbstract("BANK");
            var loanFactory = FactoryCreator.getAbstract("LOAN");

            var bankItau = bankFactory.createBank("ITAU");
            var loanBunissess = loanFactory.createLoan("BUNISESS");

            const double annualFee = 11.95;

            const double loanamount = 20000;

            const int numberOfMonthlyInstallments = 24;

            loanBunissess.getInterestRate(annualFee);

            var EMI = loanBunissess.calculateLoanPaymente(loanamount, numberOfMonthlyInstallments);

            PrintInfo(bankItau, EMI, loanamount);
        }

        public static void PrintInfo(BankBase bank, double EMI, double loanamount)
        {
            Console.WriteLine($"Seu banco: {bank.getBankName()} \n");

            Console.WriteLine($"Seu EMI mensal é R${EMI.ToString("N2")} para o valor montante do empréstimo de R${loanamount.ToString("N2")} que você pediu emprestado ");
        }
    }
}