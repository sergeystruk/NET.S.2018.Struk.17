using BLL.Interface.Abstract_level;

namespace BLL.Interface.Entities
{
    class GoldAccount : Account
    {
        public GoldAccount(IAccountNumberGenerator generator, PersonalInfo ownersPersonalInfo) : base(generator, ownersPersonalInfo)
        {
        }

        public GoldAccount(IAccountNumberGenerator generator, PersonalInfo ownersPersonalInfo, decimal balance, bool isClosed, int benefitPoints) : base(generator, ownersPersonalInfo, balance, isClosed, benefitPoints)
        {
        }

        protected override int CalculateBenefitPoints(decimal sum)
        {
            return (int)(sum * 0.02M + Balance * 0.02M);
        }
    }
}
