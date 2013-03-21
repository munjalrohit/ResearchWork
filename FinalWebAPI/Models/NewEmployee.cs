using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalWebAPI.Models
{
    public class NewEmployee
    {
        public int ID { get; set; }

        public string EmpName { get; set; }

        public string EmpDepartment { get; set; }

        public Int64 EmpMobile { get; set; }
    }
}