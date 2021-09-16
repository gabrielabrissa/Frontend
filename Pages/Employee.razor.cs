using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages
{
    public partial class EmployeePage
    {
       public IEnumerable<Employee> Employees { get; set; }

       protected override Task OnInitializedAsync()
       {
           LoadEmployees();
           return base.OnInitializedAsync();
       }
       private void LoadEmployees(){
           Employee e1 = new Employee{
               EmployeeId = 1,
               FirstName = "Gabriela",
               LastName = "Brissa",
               Email = "gabriela.brissa@si.ukdw.ac.id",
               DateOfBirth = new DateTime(2001,05,22),
               Gender = Gender.Female,
               Department = new Department{DepartmentId=1, DepartmentName="SI"},
               PhotoPath = "images/brissa.jpg"

           };
            Employee e2 = new Employee{
               EmployeeId = 1,
               FirstName = "Veronika",
               LastName = "Verasita",
               Email = "veronika.verasita@si.ukdw.ac.id",
               DateOfBirth = new DateTime(2001,05,03),
               Gender = Gender.Female,
               Department = new Department{DepartmentId=2, DepartmentName="TI"},
               PhotoPath = "images/vera.jpg"

           };
            Employee e3 = new Employee{
               EmployeeId = 3,
               FirstName = "Simfony",
               LastName = "Shopie",
               Email = "simfony.shopie@si.ukdw.ac.id",
               DateOfBirth = new DateTime(2001,03,11),
               Gender = Gender.Female,
               Department = new Department{DepartmentId=1, DepartmentName="SI"},
               PhotoPath = "images/simfony.jpg"

           };
           Employee e4 = new Employee{
               EmployeeId = 4,
               FirstName = "Carolina",
               LastName = "Nada",
               Email = "carolina.nada@si.ukdw.ac.id",
               DateOfBirth = new DateTime(2001,01,11),
               Gender = Gender.Female,
               Department = new Department{DepartmentId=1, DepartmentName="TI"},
               PhotoPath = "images/nada.jpg"

           };

           Employees = new List<Employee>{e1,e2,e3,e4};
       }
    }
}