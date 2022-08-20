using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_1.Models;

namespace Assignment_1.Controllers
{
    public class MatchdetailsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Matchdetails
        public ActionResult details()
        {
            MatchDB matchDB = new MatchDB();
            ModelState.Clear();
            return View(matchDB.GetMatchdetails());
        }
        public ActionResult winningmatchdetails()
        {
            MatchDB matchDB = new MatchDB();
            ModelState.Clear();
            return View(matchDB.WinningMatchDetails());
        }
        public ActionResult japanmatchdetails()
        {
           MatchDB matchDB=new MatchDB();
            ModelState.Clear();
            return View(matchDB.JapanMatchDetails());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FOOTBALL_LEAGUE Match)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MatchDB matchDB = new MatchDB();
                    if (matchDB.AddMatchDetails(Match))
                    {
                        ViewBag.Message = "Match Details Added Successfully";
                        ModelState.Clear();
                    }
                    else
                    { }
                    ViewBag.Message = "enter correct values";
                       
                    
                    
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}