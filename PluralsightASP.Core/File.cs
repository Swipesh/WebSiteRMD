using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;

namespace PluralsightASP.Core
{
    [Table("Files")]
    public class File
    {
        [Key,Required]
        public string Id { get; set; }
        [Required]
        public string FilePath { get; set; }
        
        [Required] 
        public string FileName { get; set; }
        
        [Required]
        public string FileType { get; set; }

        public virtual ICollection<UsersFiles> UsersFiles { get; set; }
        
    }
}