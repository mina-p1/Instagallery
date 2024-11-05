using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Instagallery.Models;
using Instagallery.Services;

namespace Instagallery.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        // GET: /Album/Index
        public async Task<IActionResult> Index()
        {
            var albums = await _albumService.GetAllAlbumsAsync();
            return View(albums);
        }

        // GET: /Album/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var album = await _albumService.GetAlbumByIdAsync(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        // GET: /Album/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Album/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AlbumModel album)
        {
            if (ModelState.IsValid)
            {
                await _albumService.CreateAlbumAsync(album);
                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

        // GET: /Album/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var album = await _albumService.GetAlbumByIdAsync(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        // POST: /Album/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AlbumModel album)
        {
            if (id != album.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _albumService.UpdateAlbumAsync(album);
                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

        // POST: /Album/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _albumService.DeleteAlbumAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
