using System;
using System.Linq;
using System.Web.Mvc;
using Stimulsoft.Report;

namespace Multi_Models_With_Stimulsoft_In_ASP.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
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
            using (var db = new Models.DBContext())
            {
                var obj = db.Provinces.Select(z => new {ProvinceName = z.Name, Citys= z.Citys}).ToList();
                var mainReport = new StiReport();
                mainReport.Load(Server.MapPath("~/Files/Report.mrt"));
                mainReport.Compile();
                mainReport["DateTimeNow"] = DateTime.UtcNow;
                mainReport.RegBusinessObject("ProvincesWithCitys", obj);
                return Stimulsoft.Report.Mvc.StiMvcViewer.GetReportSnapshotResult(HttpContext, mainReport);
            }
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