using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tests.Models;

namespace tests.Controllers
{
    public class HomeController : Controller
    {
        private TasksDBEntities db = new TasksDBEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var tasks = (from task in db.Tasks select task).ToList();
            return View(tasks);
        }

        public ActionResult Details(int id)
        {
            var tasksDetails = (from task in db.Tasks where task.TaskId==id select task).First();
            return View(tasksDetails);
        }

    }
}
