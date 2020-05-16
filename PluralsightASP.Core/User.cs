﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PluralsightASP.Core
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        /*[Required, ForeignKey(nameof(Folder))] 
        public string FolderId { get; set; }
        
        public virtual Folder Folder { get; set; }*/
    }
}