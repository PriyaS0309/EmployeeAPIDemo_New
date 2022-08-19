using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPIDemo_New.Models
{
    public class DepartmentDbContext : DbContext
    {
        public DepartmentDbContext(DbContextOptions<DepartmentDbContext> options)
            : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //Department
        //    modelBuilder.Entity<Department>().HasData(
        //        new Department { DepartmentID = 1, DepartmentName = "IT" });

        //    modelBuilder.Entity<Department>().HasData(
        //        new Department { DepartmentID = 1, DepartmentName = "Finance" });

        //    modelBuilder.Entity<Department>().HasData(
        //        new Department { DepartmentID = 1, DepartmentName = "HR" });

        //    modelBuilder.Entity<Department>().HasData(
        //        new Department { DepartmentID = 1, DepartmentName = "Admin" });

        //    //Employee

        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee { EmployeeID = 1, EmployeeName = "Priya", Email = "priya@gmail.com", DepartmentID = 1, Gender = Gender.Female });

        //    modelBuilder.Entity<Employee>().HasData(
        //       new Employee { EmployeeID = 2, EmployeeName = "Shweta", Email = "shweta@gmail.com", DepartmentID = 1, Gender = Gender.Female });

        //    modelBuilder.Entity<Employee>().HasData(
        //       new Employee { EmployeeID = 3, EmployeeName = "Twinkle", Email = "twinkle@gmail.com", DepartmentID = 2, Gender = Gender.Female });

        //    modelBuilder.Entity<Employee>().HasData(
        //       new Employee { EmployeeID = 4, EmployeeName = "Shubham", Email = "shubham@gmail.com", DepartmentID = 3, Gender = Gender.Male });
        //}
    }
}
