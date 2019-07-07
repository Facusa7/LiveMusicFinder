﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LiveMusicFinder.Data;
using LiveMusicFinder.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace LiveMusicFinder.Controllers
{
    public class LiveShowsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LiveShowsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LiveShows

        [Authorize]
        public async Task<IActionResult> Index(string sortOrder)
        {
            var list = await _context.LiveShows.ToListAsync();

            if (string.IsNullOrWhiteSpace(sortOrder)) return View(list);

            switch (sortOrder)
            {
                case "Artist":
                    list = list.OrderBy(x => x.Artist).ToList();
                    break;
                case "Venue":
                    list = list.OrderBy(x => x.Venue).ToList();
                    break;
                case "ShowDate":
                    list = list.OrderBy(x => x.ShowDate).ToList();
                    break;
                case "EnteredBy":
                    list = list.OrderBy(x => x.EnteredBy).ToList();
                    break;
            }

            return View(list);
        }

        // GET: LiveShows/Details/5
        //[Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liveShow = await _context.LiveShows
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liveShow == null)
            {
                return NotFound();
            }

            return View(liveShow);
        }

        // GET: LiveShows/Create
        [Authorize]
        public IActionResult Create()
        {
            var venues = GetVenues();
            var model = new LiveShow {Venues = venues};
            return View(model);
        }

        // POST: LiveShows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,Artist,Venue,ShowDate")] LiveShow liveShow)
        {
            liveShow.EnteredBy = User.Identity.Name;
            if (ModelState.IsValid)
            {

                var show = _context.LiveShows.FirstOrDefault(x => x.Artist == liveShow.Artist && x.ShowDate == liveShow.ShowDate);
                    
                if (show != null)
                {
                    return ValidationProblem();
                }

                _context.Add(liveShow);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(liveShow);
        }

        // GET: LiveShows/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            var currentUser = User.Identity.Name;

            if (id == null)
            {
                return NotFound();
            }

            var liveShow = await _context.LiveShows.Where(x => x.Id == id && x.EnteredBy == currentUser).FirstOrDefaultAsync();

            if (liveShow == null)
            {
                return NotFound();
            }

            liveShow.Venues = GetVenues();

            return View(liveShow);
        }

        // POST: LiveShows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Artist,Venue,ShowDate")] LiveShow liveShow)
        {
            var currentUser = User.Identity.Name;
            liveShow.EnteredBy = currentUser;
            if (id != liveShow.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingShow = await _context.LiveShows.FindAsync(id);
                   
                    existingShow.Artist = liveShow.Artist;
                    existingShow.Venue = liveShow.Venue;
                    existingShow.ShowDate = liveShow.ShowDate;
                    existingShow.EnteredBy = currentUser;

                    if(existingShow.EnteredBy != User.Identity.Name)
                    {
                        return Unauthorized();
                    }

                    var show = _context.LiveShows.FirstOrDefault(x => x.Artist == existingShow.Artist && x.ShowDate == liveShow.ShowDate);
                    
                    if (show != null)
                    {
                        return ValidationProblem();
                    }

                    _context.Update(existingShow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiveShowExists(liveShow.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(liveShow);
        }

        // GET: LiveShows/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liveShow = await _context.LiveShows
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liveShow == null)
            {
                return NotFound();
            }

            return View(liveShow);
        }

        // POST: LiveShows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var liveShow = await _context.LiveShows.FirstOrDefaultAsync(x => x.Id == id);
            _context.LiveShows.Remove(liveShow);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiveShowExists(int id)
        {
            return _context.LiveShows.Any(e => e.Id == id);
        }

        private static List<Venue> GetVenues()
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("Accept", "application/json");
                    client.Headers.Add("x-api-key", "6dgJUQD8JSb-TvbOH4jkI_6uga6KrgydMGp7");

                    var result = client.DownloadString("https://api.setlist.fm/rest/1.0/search/venues?cityName=Vienna&amp;count\r\nry=AT&amp;p=1");
                    var venueData = JsonConvert.DeserializeObject<VenueData>(result);
                    return venueData.Venue;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Venue>();
            }
            
        }
    }
}
