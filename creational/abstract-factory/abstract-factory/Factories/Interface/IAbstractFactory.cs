using abstract_factory.Domain.Entities.Base;

namespace abstract_factory.Factories.Interface
{
    public interface IAbstractFactory
    {
        BankBase createBank(string bankName);

        LoanBase createLoan(string loanName);
    }
}