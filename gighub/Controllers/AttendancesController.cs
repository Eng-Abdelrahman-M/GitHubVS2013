using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using gighub.Models;
using Microsoft.AspNet.Identity;

namespace gighub.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        private IHttpActionResult Attend([FromBody]int GigId)
        {
            string userId = User.Identity.GetUserId();

            var extists = _context.Attendances.Any(a => a.AttendeeId == userId && a.GigId == GigId);
            if (extists)
            {
                return BadRequest();
            }
            var attendace = new Attendance()
            {
                GigId = GigId,
                AttendeeId = userId
            };
            _context.Attendances.Add(attendace);
            _context.SaveChanges();

            return Ok();
        }
    }
}
