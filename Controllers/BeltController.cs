using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharpBelt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Activity = CSharpBelt.Models.Activity;
using Microsoft.EntityFrameworkCore;

namespace CSharpBelt.Controllers
{
    public class BeltController : Controller
    {
    private MyContext dbContext;
    public BeltController(MyContext context)
    {
        dbContext = context;
    }

        public bool isInSession()
    {
        if(InSession.GetUserID(HttpContext) == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    [HttpGet("Dashboard")]
    public IActionResult Dashboard()
    {
        if(isInSession() == false)
        {
            return RedirectToAction("Index", "Login");
        }
        int Sid = InSession.GetUserID(HttpContext);
        List<Activity> allAct = dbContext.Activities
            .Include(u => u.User)
            .Include(act => act.Participants)
            .ThenInclude(p => p.ParticipatingUsers)
            .ToList();
        User nowUser = dbContext.Users
            .Where(u => u.UserId == Sid)
            .FirstOrDefault();

        Dashboard model = new Dashboard();
        model.User = nowUser;
        model.allActivities = allAct;
        return View(model);
    }

    [HttpGet("view")]
    public IActionResult CreateActivity()
    {
        if(isInSession() == false)
        {
            return RedirectToAction("Index", "Login");
        }
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(NewActivity newactivity)
    {
        if(isInSession() == false)
        {
            return RedirectToAction("Index", "Login");
        }
        int Sid = InSession.GetUserID(HttpContext);
        Activity newact = new Activity();
        {
            newact.Title = newactivity.Title;
            newact.Date = newactivity.Date;
            newact.Time = newactivity.Time;
            newact.Duration = newactivity.Duration;
            newact.Description = newactivity.Description;
            newact.UserId = Sid;
            newact.CreatedAt = DateTime.Now;
            newact.UpdatedAt = DateTime.Now;
        };
            dbContext.Add(newact);
            dbContext.SaveChanges();
        Activity actid = dbContext.Activities.OrderByDescending(u => u.CreatedAt).FirstOrDefault();

        return RedirectToAction("ViewActivity", new {Aid = actid.ActivityId });

    }
        [HttpGet("viewz/{Aid}")]
        public IActionResult ViewActivity(int Aid)
        {
        if(isInSession() == false)
        {
            return RedirectToAction("Index", "Login");
        }
            int Sid = InSession.GetUserID(HttpContext);
            List<Activity> allAct = dbContext.Activities
            .Where(w => w.ActivityId == Aid)
            .Include(u => u.User)
            .Include(act => act.Participants)
            .ThenInclude(p => p.ParticipatingUsers)
            .ToList();
            User nowUser = dbContext.Users
            .Where(u => u.UserId == Sid)
            .FirstOrDefault();

            Dashboard model = new Dashboard();
            model.User = nowUser;
            model.allActivities = allAct;
            return View(model);
        }

        [HttpGet("join/{Aid}")]
        public IActionResult JoinActivity(int Aid)
        {
        if(isInSession() == false)
        {
            return RedirectToAction("Index", "Login");
        }
            int Sid = InSession.GetUserID(HttpContext);
            Participate joinact = new Participate
            {
                ActivityId = Aid,
                UserId = Sid
            };
            dbContext.Participates.Add(joinact);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        
        [HttpGet("leave/{Aid}")]
        public IActionResult LeaveActivity(int Aid)
        {
            if(isInSession() == false)
            {
                return RedirectToAction("Index", "Login");
            }
            int Sid = InSession.GetUserID(HttpContext);
            Participate currentParticipate = dbContext.Participates
            .SingleOrDefault( p => p.UserId == Sid && p.ActivityId == Aid);
            dbContext.Participates.Remove(currentParticipate);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        [HttpGet("delete/{Aid}")]
        public IActionResult DeleteActivity(int Aid)
        {
            if(isInSession() == false)
            {
                return RedirectToAction("Index", "Login");
            }
            Activity theActivity = dbContext.Activities
            .FirstOrDefault(a => a.ActivityId == Aid);
            dbContext.Activities.Remove(theActivity);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        
        
        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}