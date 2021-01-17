using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotnetCoreSession.Models;
using DotnetCoreSession.Helpers;

namespace DotnetCoreSession.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("sessionKeyStr", "hamzatas");
            HttpContext.Session.SetInt32("sessionKeyInt", 100);

            ViewBag.sessionKeyStr = HttpContext.Session.GetString("sessionKeyStr");
            ViewBag.sessionKeyInt = HttpContext.Session.GetInt32("sessionKeyInt");


            // Store Complex data in session
           List<User> _users = new List<User>()
           {
               new User() 
               {
                   Firstname = "Hamza",
                   Lastname = "TAŞ",
                   Mail = "hamzatas@*****.com",
                   Phone = "05*********",                   
               }
           };

            // Set data
            SessionHelper.SetObjectAsJson(HttpContext.Session,"User", _users);
            // Get Data
            ViewBag.UserList = SessionHelper.GetObjectFromJson<List<User>>(HttpContext.Session, "User"); ;


            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User");
            return View();
        }

        //public IActionResult Logout()
        //{
        //    HttpContext.Session.Clear();
        //    HttpContext.SignOutAsync();
        //    return View();
        //}

    }
}
