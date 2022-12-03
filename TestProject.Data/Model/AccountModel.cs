using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Data.Model
{
    public class AccountModel : BaseModel
    {
        [Required]
        public string AccountName { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
