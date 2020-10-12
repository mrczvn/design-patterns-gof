using abstract_factory.Domain.Interface;
using System;

namespace abstract_factory.Domain.Entities.Base
{
    public abstract class LoanBase : ILoan
    {
        protected double annualFee;

        public abstract void getInterestRate(double annualFee);

        public double calculateLoanPaymente(double loanamount, int numberOfMonthlyInstallments)
        {
            double monthlyFee = annualFee / 1200;

            double  EMI = (loanamount * Math.Pow(monthlyFee + 1, numberOfMonthlyInstallments) * monthlyFee) / (Math.Pow(monthlyFee + 1, numberOfMonthlyInstallments) - 1);

            return EMI;
        }
    }
}