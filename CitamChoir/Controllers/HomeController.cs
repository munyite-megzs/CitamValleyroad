using CitamChoir.Models;
using PagedList;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
namespace CitamChoir.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(int? page)
        {
            var allMembers = _context.Members
                .Include(g => g.Leader).ToList().
                ToPagedList(page ?? 1,10);
                
            return View(allMembers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}