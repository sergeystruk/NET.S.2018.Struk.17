using BLL.Interface.Abstract_level;

namespace BLL.Interface.Entities
{
    class SilverAccount : Account
    {
        public SilverAccount(IAccountNumberGenerator generator, PersonalInfo ownersPersonalInfo) : base(generator, ownersPersonalInfo)
        {
        }

        public SilverAccount(IAccountNumberGenerator generator, PersonalInfo ownersPersonalInfo, decimal balance, bool isClosed, int benefitPoints) : base(generator, ownersPersonalInfo, balance, isClosed, benefitPoints)
        {
        }

        protected override int CalculateBenefitPoints(decimal sum)
        {
            return (int)(sum * 0.01M + Balance * 0.01M);
        }
    }
}
