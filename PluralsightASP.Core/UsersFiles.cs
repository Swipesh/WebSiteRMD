using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PluralsightASP.Core
{
    [Table("UsersFiles")]
    public class UsersFiles
    {
        [Key, Required]
        public string Id { get; set; }
 
        [Required, ForeignKey(nameof(User))]
        public string UserId { get; set; }
 
        [Required, ForeignKey(nameof(File))]
        public string FileId { get; set; }
 
        public virtual File File { get; set; }
        public virtual User User { get; set; }
    }
}