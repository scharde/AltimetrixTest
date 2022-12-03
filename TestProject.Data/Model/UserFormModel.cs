using System.ComponentModel.DataAnnotations;

namespace TestProject.Data.Model
{
    public class UserFormModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int MonthlySalary { get; set; }

        [Required]
        public int MonthlyExpense { get; set; }
    }
}
