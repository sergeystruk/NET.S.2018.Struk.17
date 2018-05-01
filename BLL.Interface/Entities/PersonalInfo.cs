using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class PersonalInfo
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string PassportNumber { get; private set; }

        public PersonalInfo(string name, string surname, string email, string passportNumber)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            PassportNumber = passportNumber ?? throw new ArgumentNullException(nameof(passportNumber));
        }
    }
}
