using Microsoft.AspNetCore.Antiforgery;
using EM.Controllers;

namespace EM.Web.Host.Controllers
{
    public class AntiForgeryController : EMControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
