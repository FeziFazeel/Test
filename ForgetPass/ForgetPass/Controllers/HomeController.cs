using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForgetPass.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult sendEmail()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult sendEmail(string EnteredEmail)
        {
            string body;

            //imagine these emails stored in db
            ViewBag.email1 = "acb@gmail.com";
            ViewBag.email2 = "a22cb@gmail.com";
            ViewBag.email3 = "ac333b@gmail.com";
            ViewBag.email4 = "ac44b@gmail.com";
            ViewBag.email5 = "ac55b@gmail.com";

            //firsrt of all we check that "EnteredEmail" is exist in our or not 
            for (int i=0;i<=4;i++)
            {
                if (ViewBag.Email[i] == EnteredEmail)
                {
                    Email OE = new Email();
                    OE.SendEmail(EnteredEmail,"change password request","this is msg");
                    break;
                }

            }
            


            return View();
        }


        public ActionResult Index()
        {
            return View();
        }

       
       
    }
}