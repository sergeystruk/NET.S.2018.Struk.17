using BLL.Interface.Abstract_level;

namespace BLL.Interface.Entities
{
    class BaseAccount : Account
    {
        public BaseAccount(IAccountNumberGenerator generator, PersonalInfo ownersPersonalInfo) : base(generator, ownersPersonalInfo)
        {
        }

        public BaseAccount(IAccountNumberGenerator generator, PersonalInfo ownersPersonalInfo, decimal balance, bool isClosed, int benefitPoints) : base(generator, ownersPersonalInfo, balance, isClosed, benefitPoints)
        {
        }

        protected override int CalculateBenefitPoints(decimal sum)
        {
            return 0;
        }
    }
}
