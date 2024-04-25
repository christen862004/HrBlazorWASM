namespace HrBlazorWASM.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public string Image { get; set; }
        public int Dept_Id { get; set; }

        public override string ToString()
        {
            return $"Name:{Name} - Salary : {Salary}";
        }
    }
}
