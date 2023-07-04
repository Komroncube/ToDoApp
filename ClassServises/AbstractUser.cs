using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassServises
{
    public abstract class AbstractUser
    {
        public abstract Guid Id { get; set; }
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateOnly BirthDate { get; set; }
        public abstract string Username { get; set; }
        public abstract string Password { get; set; }

    }
}
