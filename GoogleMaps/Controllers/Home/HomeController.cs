using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GoogleMaps.Controllers.Home
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Initial Action called on view loaded
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            PopulateStates();
            return View();
        }
        /// <summary>
        /// Getting a list of states to populate dropdown
        /// </summary>
        public void PopulateStates()
        {
            Models.States s = new Models.States();
            List<SelectListItem> li = new List<SelectListItem>();

            Dictionary<string, string> dict = s.stateAbbreviationExpand();
            var keys = dict.Keys.ToList();
            foreach(var f in keys)
            {
                string stateName = dict[f];
                string stateCode = f.ToString();
                li.Add(new SelectListItem { Text = stateName, Value = stateCode });
            }
            ViewData["states"] = li;
        }

    }
}
