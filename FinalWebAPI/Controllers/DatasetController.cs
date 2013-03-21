using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalWebAPI.Controllers
{
    public class DatasetController : Controller
    {
        //
        // GET: /Dataset/

        public ActionResult Index()
        {
            ResAndDevEntitiesNEW _ent = new ResAndDevEntitiesNEW();
            var _testval=_ent.EmployeeFinals.ToList<EmployeeFinal>();
            List<EmployeeFinal> _val = new List<EmployeeFinal>();
            _val = _ent.EmployeeFinals.ToList<EmployeeFinal>();

            List<EmployeeFinal> _mylist = new List<EmployeeFinal>();

            _val.Add(new EmployeeFinal { ID = 4, EmpName = "manish", EmpDepartment = "ite", EmpMobile = 923423342 });
            _ent.SaveChanges();

            //List<GetPriceOuput> _test = new List<GetPriceOuput>();
            //_test.Add(new GetPriceOuput { Price = 200, Model = "test", Extra = "test" });

            _ent.SaveChanges();
            return View(_val);
        }

    }
}
