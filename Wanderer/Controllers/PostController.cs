using Microsoft.AspNetCore.Mvc;
using Wanderer.Data;
using Wanderer.Models;

namespace Wanderer.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext _db;

        public PostController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Post()
        {
            IEnumerable<PostsViewModel> objPosts = _db.Posts.ToList();
            return View(objPosts);
        }
    }
}
