using System.ComponentModel.DataAnnotations;

namespace TestProject.Data.Model
{
    public class UserModel
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public int MonthlySalary { get; set; }
        
        [Required]
        public int MonthlyExpense { get; set; }
        
        [Required]
        public bool IsValidForAccount { get; set; }
    }
}
