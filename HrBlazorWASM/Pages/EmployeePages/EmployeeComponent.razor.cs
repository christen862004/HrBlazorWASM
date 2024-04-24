using HrBlazorWASM.Models;

namespace HrBlazorWASM.Pages.EmployeePages
{
    public partial class EmployeeComponent
    {
        public int productId { get; set; }
        //List<Product>
        public Employee Employee { get; set; }
        public EmployeeComponent()
        {
            Employee = new Employee()
            {
                Id = 1,
                NAme = "Ahmed",
                Address = "Alexx",
                Salary = 1000
            };
        }

    }
}
