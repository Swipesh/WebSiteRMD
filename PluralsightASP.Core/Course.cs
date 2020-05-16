using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PluralsightASP.Core
{
    public class Course
    {
        [Key,Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        /*[Required,ForeignKey(nameof(Folder))]
        public string FolderId { get; set; }
        public virtual Folder Folder { get; set; }*/
        
        public virtual ICollection<User> Users { get; set; }
    }
}