using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Instagallery.Controllers
{
    public class PhotoController : Controller
    {
        // Simulated list of photos
        private static readonly List<object> _photos = new List<object>
        {
            new { Id = 1, Title = "Photo 1", Url = "/images/photos/photo1.jpg", Description = "This is Photo 1" },
            new { Id = 2, Title = "Photo 2", Url = "/images/photos/photo2.jpg", Description = "This is Photo 2" },
            new { Id = 3, Title = "Photo 3", Url = "/images/photos/photo3.jpg", Description = "This is Photo 3" },
            new { Id = 4, Title = "Photo 4", Url = "/images/photos/photo4.jpg", Description = "This is Photo 4" },
            new { Id = 5, Title = "Photo 5", Url = "/images/photos/photo5.jpg", Description = "This is Photo 5" }
        };

        // Action for the /photos route
        [HttpGet("/photos")]
        public IActionResult Index()
        {
            return View("~/Views/Gallery/Index.cshtml", _photos); // Use the view in Views/Gallery
        }
    }
}
