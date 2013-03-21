using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalWebAPI.Controllers
{
    public class JSONsampleController : Controller
    {
        //
        // GET: /JSONsample/

        public ActionResult Index()
        {
            return View();
        }

        public class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public List<Address> Addresses { get; set; }
        }

        public class Address
        {
            public string Line1 { get; set; }
            public string Line2 { get; set; }
            public string ZipCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
        }
        public class Result
        {
            public string Text { get; set; }
        }

        public JsonResult GetJsonData()
        {
            var persons = new List<Person>
                              {
                                  new Person{Id = 1, FirstName = "F1", 
                                      LastName = "L1", 
                                      Addresses = new List<Address>
                                                      {
                                                          new Address{Line1 = "LaneA"},
                                                          new Address{Line1 = "LaneB"}
                                                      }},
                                                                                                        
                                  new Person{Id = 2, FirstName = "F2", 
                                      LastName = "L2", 
                                      Addresses = new List<Address>
                                                      {
                                                          new Address{Line1 = "LaneC"},
                                                          new Address{Line1 = "LaneD"}
                                                      }}};


                return Json(persons,JsonRequestBehavior.AllowGet);
        }
        public JsonResult PostExample(int count)
        {
            // do some processing here
            var res = new Result { Text = "Received and processed " + count + " successfully." };
            return Json(res);
        }

    }
}

