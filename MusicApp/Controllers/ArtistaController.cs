using Microsoft.AspNetCore.Mvc;

namespace MusicApp.Controllers
{

    public class ArtistaController : ControllerBase
    {
        public IActionResult Index()
        {
            return NoContent();
        }
    }
}
