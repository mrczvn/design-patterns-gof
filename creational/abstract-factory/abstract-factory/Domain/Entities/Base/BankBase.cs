using abstract_factory.Domain.Interface;

namespace abstract_factory.Domain.Entities.Base
{
    public abstract class BankBase : IBank
    {
        private string bankName { get; }

        public string getBankName() => bankName;

        protected BankBase(string bankName)
        {
            this.bankName = bankName;
        }
    }
}