using Microsoft.AspNetCore.Mvc;
using Instagallery.Models;
using System.Collections.Generic;

namespace Instagallery.Controllers
{
    public class PhotoController : Controller
    {
        public IActionResult Index()
        {
            // Dummy data for testing
            var photos = new List<PhotoModel>
            {
                new PhotoModel { Id = 1, ThumbnailUrl = "/images/photo1_thumb.jpg", Title = "Photo 1" },
                new PhotoModel { Id = 2, ThumbnailUrl = "/images/photo2_thumb.jpg", Title = "Photo 2" }
            };

            // Explicitly specify the path to Gallery/Index.cshtml
            return View("~/Views/Gallery/Index.cshtml", photos);
        }

        public IActionResult Details(int id)
        {
            // Dummy data for testing
            var photo = new PhotoModel { Id = id, Url = "/images/photo" + id + ".jpg", Title = "Photo " + id, Description = "Description of Photo " + id };

            return View(photo); // Pass the photo to the view
        }
    }
}
