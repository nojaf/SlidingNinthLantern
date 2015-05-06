using System.Web.Mvc;
using SlidingNinthLantern.Models;

namespace SlidingNinthLantern.Controllers
{
    [RoutePrefix("Templates")]
    public class TemplateController : Controller
    {
        [HttpGet]
        [Route("{viewModelName}")]
        public ActionResult GetTemplate(string viewModelName)
        {
            LanternModel model = new LanternModel
            {
                Title = Resources.Resources.Title
            };

            viewModelName = char.ToUpper(viewModelName[0]) + viewModelName.Substring(1, viewModelName.Length - 1);
            string partialUrl = string.Format("~/Views/Shared/_{0}.cshtml", viewModelName);

            return PartialView(partialUrl, model);
        }
    }
}