using CitamChoir.Models;
using CitamChoir.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace CitamChoir.Controllers
{
    public class MemberController : Controller
    {

        //Get a list of generes from db

        private readonly ApplicationDbContext _context;

        public MemberController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Member
        public ActionResult Create()
        {
            var viewModel = new MembersFormViewModel {
                Occupations = _context.Occupations.ToList()

            };

            return View(viewModel);
        } 
        //[Authorize]
        //[HttpPost]
        //public ActionResult Create(MembersFormViewModel viewModel)
        //{

        //}
    }  

   
}