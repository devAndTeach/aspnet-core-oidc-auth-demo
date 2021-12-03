using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Core2AadAuth.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;

namespace Core2AadAuth.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
       

        public HomeController()
        {            
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index() => View();
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult ProtectedResource() => View();

       
    }
}
