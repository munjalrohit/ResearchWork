using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalWebAPI.Models
{
    public class Employee
    {
        public int ID { get; set; }

        public string EmpName { get; set; }

        public string EmpDepartment { get; set; }

        public Int64 EmpMobile { get; set; }

        public Employee(int _ID, string _EmpName, string _EmpDepartment, Int64 _EmpMobile)
        {
            ID = _ID;
            EmpName = _EmpName;
            EmpDepartment = _EmpDepartment;
            EmpMobile = _EmpMobile;
        }

    }
}