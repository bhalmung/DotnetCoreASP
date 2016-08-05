using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstDotnetCoreWebApplication.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstDotnetCoreWebApplication.Controllers
{
    public class TestPageController : Controller
    {
        public TestPageController(UserDetailsContext user)
        {
            _Users = user;
        }

        public UserDetailsContext _Users;
        // GET: /<controller>/
        public IActionResult Index()
        {
           var users= _Users.Users.ToList();
            return View(users);
        }
    }
}
