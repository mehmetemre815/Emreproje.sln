using Microsoft.AspNetCore.Mvc;

namespace EmreProje.Controllers.AdminPaneli
{
    public class Panel_UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
