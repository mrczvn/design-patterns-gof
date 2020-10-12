using abstract_factory.Domain.Entities.Base;

namespace abstract_factory.Domain.Entities
{
    public sealed class BankItau : BankBase
    {
        public BankItau() : base("ITAU")
        {
        }
    }
}