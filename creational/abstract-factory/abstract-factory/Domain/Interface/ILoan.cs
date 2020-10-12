namespace abstract_factory.Domain.Interface
{
    public interface ILoan
    {
        void getInterestRate(double annualFee);

        double calculateLoanPaymente(double loanamount, int numberOfMonthlyInstallments);
    }
}