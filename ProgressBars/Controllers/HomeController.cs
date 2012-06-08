using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgressBars.Models;

namespace ProgressBars.Controllers {
    public class HomeController : Controller {
        public ActionResult Index () {

            var viewModel = new List<ProgressionData>();
                
            // Randomize data
            var rnd = new Random();
            for (int i = 0; i < 100; i++) {
                var model = new ProgressionData() {
                    Total = rnd.Next(1000, 10000),
                    Progress = new List<int>()
                };
                
                for (int j = 0; j < 5; j++) {
                    model.Progress.Add(rnd.Next(0, model.Total + 1));
                }

                viewModel.Add(model);
            }

            return View(viewModel);
        }

        public ActionResult About () {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact () {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
