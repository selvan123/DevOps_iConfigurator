using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace DevOps_iConfigurator.Controllers
{
    public class QuestionsController : Controller
    {
        public static StringBuilder sb = new StringBuilder();
        private DevOpsCGEntities db = new DevOpsCGEntities();

       
        [HttpGet]
        public ActionResult Index(int? id, int? selid)
         {
            if (id is null)
            {
                Session["Option"] = "";
                return View(db.SearchQuestion1(1).ToList());
            }
            else

            if (id > 11)
            {
                Session["Option"] += selid.ToString() + ",";
                return RedirectToAction("Summary");
            }
            else
            {
                
                Session["Option"] += selid.ToString() + ",";
                return View(db.SearchQuestion1(id).ToList());
            }
          
        }

        public ActionResult Summary()
        {
           
            ViewBag.Message = "Select the plan...";
            return View();
        }

        public ActionResult UserDashBoard()
        {

            ViewBag.Message = "Installation part goes here...";
            return View();
        }


    }
}