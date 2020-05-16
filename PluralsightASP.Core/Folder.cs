using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Runtime.CompilerServices;

namespace PluralsightASP.Core
{
    [Table("Folders")]
    public class Folder
    {
        [Key,Required]
        public string Id { get; set; }
        /*[Required]
        public DirectoryInfo DirectoryInfo { get; set; } = new DirectoryInfo(".");*/
        public List<Folder> SubFolders { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}