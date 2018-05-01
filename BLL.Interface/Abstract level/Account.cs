using BLL.Interface.Abstract_level;
using BLL.Interface.Entities;
using System;

namespace BLL.Interface
{
    public abstract class Account
    {
        #region Fields and properties
        public int NumberOfAccount { get; private set; }
        public PersonalInfo OwnersPersonalInfo { get; private set; }
        public decimal Balance { get; private set; }
        internal bool isClosed;
        private int benefitPoints;
        #endregion

        #region Constructors
        public Account(IAccountNumberGenerator generator, PersonalInfo ownersPersonalInfo, decimal balance, bool isClosed, int benefitPoints)
        {
            NumberOfAccount = generator.Generate();
            OwnersPersonalInfo = ownersPersonalInfo ?? throw new ArgumentNullException(nameof(ownersPersonalInfo));
            Balance = balance;
            this.isClosed = isClosed;
            this.benefitPoints = benefitPoints;
        }

        public Account(IAccountNumberGenerator generator, PersonalInfo ownersPersonalInfo) : this(generator, ownersPersonalInfo, 0, true, 0)
        {
            OwnersPersonalInfo = ownersPersonalInfo ?? throw new ArgumentNullException(nameof(ownersPersonalInfo));
        }
        #endregion

        #region Methods
        public void Deposit(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sum));
            }

            Balance += sum;
            benefitPoints += CalculateBenefitPoints(sum);
        }

        public void Withdraw(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sum));
            }

            Balance -= sum;
            benefitPoints -= CalculateBenefitPoints(sum);
        }

        public void Close() => isClosed = true;

        protected abstract int CalculateBenefitPoints(decimal sum);
        #endregion
    }
}
