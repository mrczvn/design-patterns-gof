using abstract_factory.Domain.Util;
using abstract_factory.Factories.Interface;
using System;

namespace abstract_factory.Factories
{
    public abstract class FactoryCreator
    {
        public static IAbstractFactory getAbstract(string choice)
        {
            if (IgnoreCase.equalIgnoreCase(choice, "Bank"))
            {
                return new BankFactory();
            }
            else if (IgnoreCase.equalIgnoreCase(choice, "Loan"))
            {
                return new LoanFactory();
            }

            throw new ArgumentOutOfRangeException(nameof(choice), choice, null);
        }
    }
}