using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entitites;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(TodoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            if (value != null)
            {
                context.ToDoLists.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(TodoList toDoList)
        {
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            if (value != null)
            {
                value.Status = true;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            if (value != null)
            {
                value.Status = false;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}