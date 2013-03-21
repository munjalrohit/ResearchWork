using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using FinalWebAPI.Models;

namespace FinalWebAPI.Controllers
{
    public class EmployeeAPIController : ApiController
    {
        private List<Employee> EmpList = new List<Employee>();

        public EmployeeAPIController()
        {

            EmpList.Add(new Employee(1, "Employee1", "Employee Department1", 9999888877));
            EmpList.Add(new Employee(2, "Employee2", "Employee Department2", 7777888899));
            EmpList.Add(new Employee(3, "Employee3", "Employee Department3", 9999777788));
            EmpList.Add(new Employee(4, "Employee4", "Employee Department4", 9876489276));
        }


        public IEnumerable<Employee> GetEmployees()
        {
            //ResAndDevEntities DBentity = new ResAndDevEntities();

           // return DBentity.EmployeeFinals.ToList();
            return EmpList;
        }

        
        public Employee GetEmployee(int id)
        {
            return EmpList.Find(p => p.ID == id);
        }
        // GET api/employeeapi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/employeeapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/employeeapi
        [HttpPost]
        public IEnumerable<Employee> AddEmployee(Employee value)
        {
            EmpList.Add(value);
            return EmpList;
        }

       
   

        // PUT api/employeeapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/employeeapi/5
        [HttpDelete]
        public IEnumerable<Employee> DeleteEmployee(int id)
        {
            EmpList.Remove(EmpList.Find(E => E.ID == id));
            return EmpList;
        }

        
    }
}
