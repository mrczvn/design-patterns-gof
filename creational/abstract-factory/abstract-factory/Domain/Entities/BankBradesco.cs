using abstract_factory.Domain.Entities.Base;

namespace abstract_factory.Domain.Entities
{
    public sealed class BankBradesco : BankBase
    {
        public BankBradesco() : base("BRADESCO")
        {
        }
    }
}