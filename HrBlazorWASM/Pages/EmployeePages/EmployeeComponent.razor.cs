using HrBlazorWASM.Models;

namespace HrBlazorWASM.Pages.EmployeePages
{
    public partial class EmployeeComponent
    {
        
        public Employee Employee { get; set; }
        public EmployeeComponent()
        {
            Employee = new Employee()
            {
                Id = 1,
                Name = "Ahmed",
                
                Salary = 1000
            };
        }

      
    }
}
