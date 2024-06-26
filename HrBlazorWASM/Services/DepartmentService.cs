﻿using HrBlazorWASM.Models;

namespace HrBlazorWASM.Services
{
    public class DepartmentService
    {
        List<Department> Depts { get; set; } = new List<Department>();
        public DepartmentService()
        {
            Depts.Add(new Department() { Id = 1, Name = "SD" });
            Depts.Add(new Department() { Id = 2, Name = "Web & Mobile" });
            Depts.Add(new Department() { Id = 3, Name = "2D" });
            Depts.Add(new Department() { Id = 4, Name = "Digital Marketing" });

        }
        public List<Department> getAll()
        {
            return Depts;
        }
        public Department getById(int id)
        {
            return Depts.FirstOrDefault(d => d.Id == id);
        }
    }
}
