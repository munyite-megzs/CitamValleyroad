using CitamChoir.Dto;
using CitamChoir.Models;
using System;
using System.Linq;
using System.Web.Http;

namespace CitamChoir.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] AttendanceForCreationDto attendanceForCreation)
        {
            if (attendanceForCreation == null)
            {
                return NotFound();
            }


            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            DateTime attendanceDate = DateTime.Parse(attendanceForCreation.DateTime);
            string attDate = (attendanceDate.DayOfWeek).ToString();

            if (!attDate.Equals( "Thursday"))
            {
                if (!attDate.Equals("Saturday"))
                {
                    return BadRequest("Wrong date Choice. Attendance should be done for Thursday and Saturday only!");
                }
               
            }

            //look up for the current date with phone number and see whether the item has been already saved.

            var checkForDuplicate = _context.Attendances.Any(a => a.PhoneNumber == attendanceForCreation.PhoneNumber);


            if (checkForDuplicate)
            {
                return BadRequest("The attendance for " + attendanceForCreation.DateTime + " Already marked.");
            }


            var attendance = new Attendance
            {
                FirstName = attendanceForCreation.FirstName,
                OtherName = attendanceForCreation.OtherName,
                DateTime = DateTime.Parse( attendanceForCreation.DateTime),
                Remarks = attendanceForCreation.Remarks,
                Attended = attendanceForCreation.Attended,
                LeaderId = 1,
                VoiceId = attendanceForCreation.VoiceId,
                PhoneNumber = attendanceForCreation.PhoneNumber
                


            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();

        }
    }
}
