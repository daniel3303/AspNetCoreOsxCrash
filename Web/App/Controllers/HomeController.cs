using Microsoft.AspNetCore.Mvc;

namespace Intranet.Web.Portal.Controllers;

public class HomeController : Controller {
    public IActionResult Index() {
        return View();
    }
}