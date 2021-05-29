using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using sample.Controllers;

namespace sample.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : sampleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
