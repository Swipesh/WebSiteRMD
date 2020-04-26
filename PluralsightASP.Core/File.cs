using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PluralsightASP.Core
{
    [Table("Files")]
    public class File
    {
        [Key,Required]
        public string Id { get; set; }
        [Required]
        public string Path { get; set; }
        public bool IsAccessibleToAll { get; set; }
        
        public virtual ICollection<UsersFiles> UsersFiles { get; set; }
        
    }
}