﻿using System.Web.Mvc;

namespace FinalWebAPI.Areas.Area2
{
    public class Area2AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Area2";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Area2_default",
                "Area2/{controller}/{action}/{id}",
                new { Controller = "HomeArea2", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
