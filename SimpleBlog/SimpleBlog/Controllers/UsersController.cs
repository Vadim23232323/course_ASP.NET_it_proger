using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            UsersModel user = new UsersModel();
            int age = 10 / user.age;
            return View();
        }

        public ActionResult ListUsers()
        {

            List<UsersModel> users = new List<UsersModel>();
            users.Add(new UsersModel("tom", "jack", 22, false));
            users.Add(new UsersModel("vadim", "jack", 27, false));
            users.Add(new UsersModel("tatia", "jack", 24, false));
            users.Add(new UsersModel("maks", "jack", 5, false));
            return View(users);
        }
    }
}