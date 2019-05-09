using CitamChoir.Models;
using CitamChoir.ViewModel;
using Microsoft.AspNet.Identity;
using System;
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
                Occupations = _context.Occupations.ToList(),
                Voices = _context.Voices.ToList(),
                Leaders = _context.Leaders.ToList()

            };

            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MembersFormViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                viewModel.Occupations = _context.Occupations.ToList();
                viewModel.Voices = _context.Voices.ToList();
                viewModel.Leaders = _context.Leaders.ToList();
                return View("Create",viewModel);
            }

            var member = new Member
            {
                VoiceLeaderId = User.Identity.GetUserId(),
                FirstName = viewModel.FirstName,
                OtherNames = viewModel.OtherNames,
                Gender = viewModel.FialGender,
                OccupationId = viewModel.Occupation,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                InductionDate = viewModel.GetDateTime(),
                BGV = viewModel.BGV,
                WorshipLeader = viewModel.WorshipLeader,
                LeaderId = viewModel.Leader,
                VoiceId= viewModel.Voice

            };
            try
            {
                _context.Members.Add(member);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                
                    string res = ex.Message;
                
            }
           
           

            return RedirectToAction("Index", "Home");

        }
    }


}