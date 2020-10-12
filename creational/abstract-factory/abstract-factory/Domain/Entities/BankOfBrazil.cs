using abstract_factory.Domain.Entities.Base;

namespace abstract_factory.Domain.Entities
{
    public sealed class BankOfBrazil : BankBase
    {
        public BankOfBrazil() : base("BANCO DO BRASIL")
        {
        }
    }
}