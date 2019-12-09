using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Api.Controllers
{
    public class FallbackController : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwroot", "index.html"), "text/HTML");
        }
    }
}