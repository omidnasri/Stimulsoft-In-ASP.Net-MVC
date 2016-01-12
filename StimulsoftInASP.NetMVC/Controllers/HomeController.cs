using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StimulsoftInASP.NetMVC.Models;

namespace StimulsoftInASP.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult StiReport()
        {
            // List of persons: 
            // you can change the following list to list of persons that get from database.
            var persons = new List<Models.Person>()
            {
                new Person() {Id = 0, FirstName = "sadar", LastName = "marvati", Gender = true}
                , new Person() {Id = 1, FirstName = "omid", LastName = "nasri", Gender = true}
                 , new Person() {Id = 2, FirstName = "hana", LastName = "akbari", Gender = false}
                  , new Person() {Id = 3, FirstName = "ali", LastName = "jahani", Gender = true }
                   , new Person() {Id = 4, FirstName = "sara", LastName = "sabori", Gender = false }
            };
            var mainReport = new Stimulsoft.Report.StiReport();
            mainReport.Load(Server.MapPath("~/Files/Report.mrt"));
            mainReport.Compile();
            mainReport.RegBusinessObject("persons_business", persons);
            return Stimulsoft.Report.Mvc.StiMvcViewer.GetReportSnapshotResult(mainReport);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult ViewerEvent()
        {
            return Stimulsoft.Report.Mvc.StiMvcViewer.ViewerEventResult(HttpContext);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult Print()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult PrintReport()
        {
            return Stimulsoft.Report.Mvc.StiMvcViewer.PrintReportResult(HttpContext);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual FileResult ExportReport()
        {
            return Stimulsoft.Report.Mvc.StiMvcViewer.ExportReportResult(HttpContext);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult Interaction()
        {
            return Stimulsoft.Report.Mvc.StiMvcViewer.InteractionResult(HttpContext);
        }
    }
}