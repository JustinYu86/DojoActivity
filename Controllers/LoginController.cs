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

namespace CSharpBelt.Controllers
{
        public class LoginController : Controller
        {
        private MyContext dbContext;
        public LoginController(MyContext context)
        {
            dbContext = context;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(Register newReg)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newReg.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                else
                {
                    User newUser = new User(newReg);
                    PasswordHasher<User> Hash = new PasswordHasher<User>();
                    newUser.Password = Hash.HashPassword(newUser, newUser.Password);
                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();
                    InSession.SetLogin(HttpContext, newUser.UserId);
                    return RedirectToAction("Dashboard", "Belt", new { Sid = newUser.UserId});
                }
            }
            else
            {
            return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(Login user)
        {
            if(ModelState.IsValid)
            {
                User checkUser = dbContext.Users.FirstOrDefault(u => u.Email == user.LoginEmail);
                if(checkUser == null)
                {
                    ModelState.AddModelError("LoginEmail", "Email is not correct!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                var validate = Hasher.VerifyHashedPassword(checkUser, checkUser.Password, user.LoginPassword);
                if(validate == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Password is not correct!");
                    return View("Index");
                }
                else
                {
                    InSession.SetLogin(HttpContext, checkUser.UserId);
                    return RedirectToAction("Dashboard", "Belt", new { Sid = checkUser.UserId});
                }  
            }
            else
            {
                return View("Index");
            }
        }
    }
}
