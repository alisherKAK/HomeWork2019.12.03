using HomeWork2019._12._03.DataAccess;
using HomeWork2019._12._03.Models;
using HomeWork2019._12._03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2019._12._03.Web.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            DbRepository<Task> repository = new DbRepository<Task>(new TaskContext());
            ViewBag.Data = repository.Get();
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPost(Task task)
        {
            DbRepository<Task> repository = new DbRepository<Task>(new TaskContext());
            repository.Add(task);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult ChangeState(int id)
        {
            DbRepository<Task> repository = new DbRepository<Task>(new TaskContext());
            
            var tasks = repository.Get().ToList();
            var task = tasks.Where(t => t.Id == id).FirstOrDefault();
            task.IsDone = !task.IsDone;

            repository.Update(task);

            return RedirectToAction("Index");
        }
        public ActionResult Search(string name)
        {
            DbRepository<Task> repository = new DbRepository<Task>(new TaskContext());
            var tasks = repository.Get().Where(t => t.Name == name).ToList();
            ViewBag.Data = tasks == null ? new List<Task>() : tasks;
            return View();
        }
    }
}