using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Odbc;

namespace PluralsightASP.Core
{
    [Table("UsersFiles")]
    public class UsersFiles
    {
        
        [Required, ForeignKey(nameof(File))] 
        public string FileId { get; set; }

        
        [Required, ForeignKey(nameof(User))]
        public string UserId { get; set; }


        public virtual File File { get; set; }
        public virtual User User { get; set; }
    }
}