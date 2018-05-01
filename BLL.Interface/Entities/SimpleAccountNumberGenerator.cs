using BLL.Interface.Abstract_level;

namespace BLL.Interface.Entities
{
    sealed class SimpleAccountNumberGenerator : IAccountNumberGenerator
    {
        private static int currentNumber = 0;
        public static int Generate()
        {
            return Generate();
        }
        
        int IAccountNumberGenerator.Generate()
        {
            return currentNumber++;
        }
    }
}
