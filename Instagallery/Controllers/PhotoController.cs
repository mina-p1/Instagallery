using Instagallery.Data;
using Instagallery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Instagallery.Controllers
{
    public class PhotoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhotoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var photos = _context.Photos.ToList();
            return View(photos); // Pass the database photos to the view
        }
    }
}
