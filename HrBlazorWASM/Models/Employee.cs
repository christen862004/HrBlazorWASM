using System.ComponentModel.DataAnnotations;

namespace HrBlazorWASM.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3,ErrorMessage ="Name Must Be More Than 2 Char")]
        public string Name { get; set; }

        [Range(6000,20000)]
        public int Salary { get; set; }

        
        public string Image { get; set; }

        public int Dept_Id { get; set; }

        public override string ToString()
        {
            return $"Name:{Name} - Salary : {Salary}";
        }
    }
}
