using Microsoft.AspNetCore.Mvc;
using resumeadaptorv2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace resumeadaptorv2.Controllers
{
    //mod07.05 ajout context
    public class SQLUsersDataController
    {
        private usersDbContext _context { get; set; }
        public SQLUsersDataController(usersDbContext context)
        {
            _context = context;
        }
        public void Add(UserProfile emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
        }
        public UserProfile Get(int ID)
        {
            return _context.Users.FirstOrDefault(e => e.UserId == ID);
        }
        public int GetSum()
        {
            return _context.Users.Count();
        }
    }
        public class HomeController : Controller
    {
        public string emailadress;
        public string userpassword;
        
        
        public IActionResult Index()
        {
            using (var context = new usersDbContext())
            {
                SQLUsersDataController sqlData = new SQLUsersDataController(context);
                TempData["usersCount"] = sqlData.GetSum();
                TempData.Save();
            }
                return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult RedirectLogin([Bind("email,Password")] UserProfile userprofile)
        {
            TempData["mail"] = String.Copy(userprofile.email); //"test temps data";
            TempData["password"] = String.Copy(userprofile.Password); //"test temps data";
            TempData.Save();
            Boolean loginsucces = false;
            
            if (loginsucces) return RedirectToAction("truetestresult", "Home");
            else
            return RedirectToAction("LoginError", "Home");
        }
        /*
        public IActionResult Login(string LoginError)
        {
            return View(LoginError);
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult LoginError()
        {
            
            ViewBag.email = TempData["mail"];
            ViewBag.password = userpassword;
            return View();
        }
        public IActionResult truetestresult()
        {
            ViewBag.email = TempData["mail"];// emailadress;//l'affectation est correcte mais la variable est nulle
            return View();
        }
        public IActionResult falsetestresult()
        {
            return View();
        }
    }
}
