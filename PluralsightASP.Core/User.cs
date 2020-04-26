using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace PluralsightASP.Core
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public virtual ICollection<UsersFiles> UsersFiles { get; set; }
    }
}