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
        
        [Required,ForeignKey(nameof(Folder))] 
        public string FolderId { get; set; }

        public virtual Folder Folder { get; set; }
    }
}