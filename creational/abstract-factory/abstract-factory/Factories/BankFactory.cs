using abstract_factory.Domain.Entities;
using abstract_factory.Domain.Entities.Base;
using abstract_factory.Domain.Util;
using abstract_factory.Factories.Interface;
using System;

namespace abstract_factory.Factories
{
    public sealed class BankFactory : IAbstractFactory
    {
        public BankBase createBank(string bankName)
        {
            if (IgnoreCase.equalIgnoreCase(bankName, "ITAU"))
            {
                return new BankItau();
            }
            else if (IgnoreCase.equalIgnoreCase(bankName, "BANCO DO BRASIL"))
            {
                return new BankOfBrazil();
            }
            else if (IgnoreCase.equalIgnoreCase(bankName, "BRADESCO"))
            {
                return new BankBradesco();
            }

            throw new ArgumentOutOfRangeException(nameof(bankName), bankName, null);
        }

        public LoanBase createLoan(string loanName) => null;
    }
}