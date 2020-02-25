using gighub.Models;
using gighub.View_Models;
using System.Linq;
using System.Web.Mvc;

namespace gighub.Controllers
{
    public class GigController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Gig
        public ActionResult Create()
        {
            var viewModel = new GigViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}