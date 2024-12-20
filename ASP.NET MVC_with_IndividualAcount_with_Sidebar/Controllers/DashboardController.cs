using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_with_IndividualAcount_with_Sidebar.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
