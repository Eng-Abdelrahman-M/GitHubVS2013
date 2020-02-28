using gighub.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Web.Http;
using System.Web.Http.Results;

namespace gighub.Controllers
{
    public class UserNameController : ApiController
    {
        private ApplicationDbContext _context;

        public UserNameController()
        {
            _context = new ApplicationDbContext();
        }

        [System.Web.Http.HttpGet]
        public JsonResult<string> getName()
        {
            String name = _context.Users.Find(User.Identity.GetUserId()).Name;
            return Json(name);
        }
    }
}
