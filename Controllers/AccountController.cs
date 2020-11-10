using Microsoft.AspNetCore.Mvc;
using NightFlow.Messenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightFlow.Messenger.Controllers
{
    public class AccountController : Controller
    {
        private MessengerDbContext db;
        public AccountController(MessengerDbContext dbContext)
        {
            db = dbContext;
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
