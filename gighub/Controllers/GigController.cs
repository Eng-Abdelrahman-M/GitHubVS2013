﻿using gighub.Models;
using gighub.View_Models;
using Microsoft.AspNet.Identity;
using System;
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

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigViewModel viewModel)
        {


            var gig = new Gig()
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(String.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}