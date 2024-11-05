// By Peter Mina

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Instagallery.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoService _photoService;

        public PhotoViewController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        // Display the main gallery with grid layout
        [HttpGet]
        public async Task<IActionResult> Gallery()
        {
            var photos = await _photoService.GetAllPhotosAsync(); // API Integration coming later
            return View(photos);
        }

        // Display a single photo in lightbox view
        [HttpGet]
        public async Task<IActionResult> Lightbox(int id)
        {
            var photo = await _photoService.GetPhotoByIdAsync(id); // API Integration coming later
            if (photo == null)
            {
                return NotFound();
            }
            return View(photo);
        }
    }
}