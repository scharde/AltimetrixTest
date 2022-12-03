using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Data.Entity
{
    public class AccountEntity : BaseEntity
    {
        [Required]
        public string AccountName { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
