using Microsoft.AspNetCore.Mvc;
using FireOnWheels.Registration.Web.ViewModels;
using FireOnWheels.Registration.Web.Messages;

namespace FireOnWheels.Registration.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult RegisterOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterOrder(OrderViewModel model)
        {
            var registerOrderCommand = new RegisterOrderCommand(model);

            //Send RegisterOrderCommand

            return View("Thanks");
        }
    }
}
