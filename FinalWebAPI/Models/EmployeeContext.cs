using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;




namespace FinalWebAPI.Models
{
    public class EmployeeContext:DbContext
    {
        //public EmployeeContext() : base("name=ResAndDevEntities")
        //   { 

        //   }
 
        public DbSet<Employee> Employees { get; set; }

        public DbSet<NewEmployee> NewEmployees { get; set; }
        
    }
}