using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SlackWebhook.Web.Models;
using Microsoft.AspNetCore.Authorization;
using SlackWebhook.Domain.Models;
using SlackWebhook.Domain.Models.Entity;

namespace SlackWebhook.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginModel model)
        {
            ModelState.AddModelError(string.Empty, "入力値は100以上の値を指定してください。");

            return View(model);
        }

        [AllowAnonymous]
        public IActionResult AddUser()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AddUser(LoginModel model)
        {
            using (var db = new SlackDbContext())
            {
                db.Set<UserEntity>().Add(UserEntity.Create(model.Id, model.Pw));
            }
            return View();
        }
    }
}