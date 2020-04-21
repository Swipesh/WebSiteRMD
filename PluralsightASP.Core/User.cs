using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace PluralsightASP.Core
{
    public class User : IdentityUser
    {
        private IEnumerable<string> Files { get; set; }
    }

    
}