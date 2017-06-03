using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BoasPraticasAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly EnviromentOptions _options;

        public HomeController(IOptions<EnviromentOptions> optionsAccessor)
        {
            _options = optionsAccessor.Value;
        }

        public IActionResult Index()
        {
            ViewBag.Key = _options.Key;
            ViewBag.Password = _options.Password;

            ViewBag.Cultura = CultureInfo.CurrentCulture.DisplayName;

            return View();
        }
    }
}
