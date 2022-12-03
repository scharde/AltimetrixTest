using System.ComponentModel.DataAnnotations;

namespace TestProject.Data.Entity
{
    public class UserEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int MonthlySalary { get; set; }
        [Required]
        public int MonthlyExpense { get; set; }
        [Required] 
        public bool IsValidForAccount { get; set; }
    }
}
