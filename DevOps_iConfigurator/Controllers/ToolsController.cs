using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevOps_iConfigurator.Controllers
{
    public class ToolsController : Controller
    {
        // GET: Tools
        public ActionResult Index()
        {
            System.Diagnostics.Process.Start(@"D:\\Users\\sjamgade\\Desktop\\DevOps_iConfigurator\\DevOps_iConfigurator\\CF_Batch_Script\\Jenkins.bat");
            System.Diagnostics.Process.Start(@"D:\\Users\\sjamgade\\Desktop\\DevOps_iConfigurator\\DevOps_iConfigurator\\CF_Batch_Script\\Tomcat.bat");
            System.Diagnostics.Process.Start(@"D:\\Users\\sjamgade\\Desktop\\DevOps_iConfigurator\\DevOps_iConfigurator\\CF_Batch_Script\\artifactory.bat");
            System.Diagnostics.Process.Start(@"D:\\Users\\sjamgade\\Desktop\\DevOps_iConfigurator\\DevOps_iConfigurator\\CF_Batch_Script\\sonar.bat");

            return View();
            
            
           
        }
    }
}