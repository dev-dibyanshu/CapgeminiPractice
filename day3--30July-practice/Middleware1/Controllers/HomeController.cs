using Microsoft.AspNetCore.Mvc;

namespace Middleware1.Controllers{
    public class HomeController : Controller{
        public string Index(){
            return "This is a message from Home controller.";
        }
    }
}