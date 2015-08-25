using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tests.Models;

namespace tests.Controllers
{
    public class AdminController : Controller
    {
        private TasksDBEntities db = new TasksDBEntities();
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            var tasks = (from task in db.Tasks select task).ToList();
            return View(tasks);
        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id)
        {
            var tasksDetails = (from task in db.Tasks where task.TaskId == id select task).First();
            return View(tasksDetails);
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            Tasks task = new Tasks();
            return View(task);
        } 

        //
        // POST: /Admin/Create

        [HttpPost]
        public ActionResult Create(Tasks task)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.AddToTasks(task);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex); 
            }
            return View(task);
        }
        
        //
        // GET: /Admin/Edit/5
 
        public ActionResult Edit(int id)
        {
            var tasksEdit = (from task in db.Tasks where task.TaskId == id select task).First();
            return View(tasksEdit);
        }

        //
        // POST: /Admin/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var tasksEdit = (from task in db.Tasks where task.TaskId == id select task).First();
            try
            {
                UpdateModel(tasksEdit);
                db.SaveChanges();
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View(tasksEdit);
            }
        }

        //
        // GET: /Admin/Delete/5
 
        public ActionResult Delete(int id)
        {
            var tasksDelete = (from task in db.Tasks where task.TaskId == id select task).First();
            return View(tasksDelete);
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var tasksDelete = (from task in db.Tasks where task.TaskId == id select task).First();
            try
            {
                db.DeleteObject(tasksDelete);
                db.SaveChanges();
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View(tasksDelete);
            }
        }
    }
}
