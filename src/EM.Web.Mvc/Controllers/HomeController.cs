using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using EM.Controllers;

namespace EM.Web.Controllers
{
   [AbpMvcAuthorize]
   public class HomeController : EMControllerBase
   {
      public ActionResult Index()
      {
         return View();
      }
   }
}