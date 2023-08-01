using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }

        public PartialViewResult HeadPartialView()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartialView()
        {
            return PartialView();
        }
        public PartialViewResult SideBarPartialView()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartialView()
        {
            return PartialView();
        }
        public PartialViewResult ScriptsPartialView()
        {
            return PartialView();
        }


    }
}
