using System.Web.Mvc;

namespace FinalWebAPI.Areas.Area1
{
    public class Area1AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Area1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Area1_default",
                "Area1/{controller}/{action}/{id}",
                new { Controller = "HomeArea1", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
