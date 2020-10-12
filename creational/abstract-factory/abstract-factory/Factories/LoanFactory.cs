using abstract_factory.Domain.Entities;
using abstract_factory.Domain.Entities.Base;
using abstract_factory.Domain.Util;
using abstract_factory.Factories.Interface;
using System;

namespace abstract_factory.Factories
{
    public sealed class LoanFactory : IAbstractFactory
    {
        public LoanBase createLoan(string loanName)
        {
            if (IgnoreCase.equalIgnoreCase(loanName, "HOME"))
            {
                return new HomeLoan();
            }
            else if (IgnoreCase.equalIgnoreCase(loanName, "BUNISESS"))
            {
                return new BunissessLoan();
            }
            else if (IgnoreCase.equalIgnoreCase(loanName, "EDUCATION"))
            {
                return new EducationLoan();
            }

            throw new ArgumentOutOfRangeException(nameof(loanName), loanName, null);
        }

        public BankBase createBank(string bankName) => null;
    }
}