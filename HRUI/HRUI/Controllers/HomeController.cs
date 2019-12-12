using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRModel;
using HRIBLL;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HRUI.Controllers
{
    public class HomeController : Controller
    {
        public IuserBLL iub { get; set; }
        public ActionResult Index()
        {
        
            return View();
        }
        public async Task<ActionResult> Index2()
        {
            List<M_users> list = await iub.SelectUser();
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }

        public ActionResult About()
        {
      

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}