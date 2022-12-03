using System.ComponentModel.DataAnnotations;

namespace TestProject.Data.Model
{
    public class AccountFormModel
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string AccountName { get; set; }
    }
}
