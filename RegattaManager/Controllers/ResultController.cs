﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegattaManager.Data;
using RegattaManager.Models;
using Microsoft.EntityFrameworkCore;

namespace RegattaManager.Controllers
{
    public class ResultController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchLastName, string All)
        {
            ViewData["CurrentFilter"] = searchLastName;

            var model = _context.Races.Include(e => e.Boatclass).Include(e => e.Oldclass).Include(e => e.Raceclass).Include(e => e.Racestatus).Include(e => e.Startboats).Where(e => e.RacestatusId == 3).OrderByDescending(e => e.Starttime).Take(10);
            ViewBag.startboats = _context.Startboats.Include(e => e.Club).Include(e => e.Startboatstatus).OrderBy(e => e.RaceId).ThenBy(e => e.Placement);
            ViewBag.disqsbs = _context.Startboats.Include(e => e.Club).Include(e => e.Startboatstatus).Where(e => e.Placement <= 0).OrderBy(e => e.Startslot);
            ViewBag.startboatmembers = _context.StartboatMembers;
            ViewBag.members = _context.Members;

            if (!String.IsNullOrEmpty(searchLastName))
            {
                var sbm = _context.StartboatMembers.Where(e => e.Member.LastName.ToLower().Contains(searchLastName.ToLower()));
                var sb = new List<Startboat>();
                var races = new List<Race>();
                var allRaces = _context.Races.Include(e => e.Boatclass).Include(e => e.Oldclass).Include(e => e.Raceclass).Include(e => e.Racestatus).Include(e => e.Startboats).Where(e => e.RacestatusId == 3).OrderByDescending(e => e.Starttime);

                foreach (var stbm in sbm)
                {
                    sb.Add(_context.Startboats.Include(e => e.StartboatMembers).Where(e => e.StartboatId == stbm.StartboatId).Single());
                }
                foreach (var sbsgl in sb)
                {
                    foreach (var r in allRaces)
                    {
                        if (r.RaceId == sbsgl.RaceId)
                        {
                            races.Add(r);
                        }
                    }
                }
                return View(races);
            }

            if (!String.IsNullOrEmpty(All))
            {
                ViewData["All"] = "1";
                var races = _context.Races.Include(e => e.Boatclass).Include(e => e.Oldclass).Include(e => e.Raceclass).Include(e => e.Racestatus).Include(e => e.Startboats).Where(e => e.RacestatusId == 3).OrderBy(e => e.Starttime);

                return View(races);
            }

            return View(model.ToList());
        }

        public IActionResult TV()
        {
            ViewBag.raceresults = _context.Races.Include(e => e.Boatclass).Include(e => e.Oldclass).Include(e => e.Raceclass).Include(e => e.Racestatus).Include(e => e.Startboats).Where(e => e.RacestatusId == 3).OrderByDescending(e => e.Starttime).Take(6);
            ViewBag.startboats = _context.Startboats.Include(e => e.Club).Include(e => e.Startboatstatus).OrderBy(e => e.RaceId).ThenBy(e => e.Placement);
            ViewBag.disqsbs = _context.Startboats.Include(e => e.Club).Include(e => e.Startboatstatus).Where(e => e.Placement <= 0).OrderBy(e => e.Startslot);
            ViewBag.startboatmembers = _context.StartboatMembers;
            ViewBag.members = _context.Members;
            ViewBag.raceplanned = _context.Races.Include(e => e.Boatclass).Include(e => e.Oldclass).Include(e => e.Raceclass).Include(e => e.Racestatus).Include(e => e.Startboats).Where(e => e.RacestatusId == 1 && e.FinishType > 0 && e.Startboats.Count > 0).OrderBy(e => e.Starttime).Take(6);

            return View();
        }
    }
}