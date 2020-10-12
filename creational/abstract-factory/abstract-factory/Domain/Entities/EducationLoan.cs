using abstract_factory.Domain.Entities.Base;

namespace abstract_factory.Domain.Entities
{
    public sealed class EducationLoan : LoanBase
    {
        public override void getInterestRate(double annualFee) => this.annualFee = annualFee;
    }
}