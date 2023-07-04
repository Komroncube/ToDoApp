using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassServises
{
    public class User : AbstractUser
    {
        public override Guid Id { get; set; }
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override DateOnly BirthDate { get; set; }
        public override string Username { get; set; }
        public override string Password { get; set; }
        public User()
        {
            Id= Guid.NewGuid();
        }
    }
}
