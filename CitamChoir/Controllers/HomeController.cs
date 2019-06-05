using CitamChoir.Models;
using PagedList;
using System;
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




            var members = _context.Members.Include(g => g.Voice).ToList().Count();
            var sopranos = _context.Members.Include(g => g.VoiceId).Where(a => a.VoiceId == 3).Count();
            var altos = _context.Members.Include(g => g.VoiceId).Where(a => a.VoiceId == 2).Count();
            var tenors = _context.Members.Include(g => g.VoiceId).Where(a => a.VoiceId == 4).Count();
            var bass = _context.Members.Include(g => g.VoiceId).Where(a => a.VoiceId == 1).Count();
            var band = _context.Members.Include(g => g.VoiceId).Where(a => a.VoiceId == 5).Count();

            //ViewBag.TotalStudents = studentList.Count();
            ViewBag.TotalMembers = members;
            ViewBag.TotalSopranos = sopranos;
            ViewBag.TotalAltos = altos;
            ViewBag.TotalTenors = tenors;
            ViewBag.TotalBass = bass;
            ViewBag.TotalBand = band;



            var allMembers = _context.Members
               .Include(g => g.Voice)
            
               .ToList().
               ToPagedList(page ?? 1, 10);

            return View(allMembers);



        }

        private string GetStatus()
        {
            throw new NotImplementedException();
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