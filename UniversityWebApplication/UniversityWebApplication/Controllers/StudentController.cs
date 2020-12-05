using Microsoft.AspNetCore.Mvc;
using UniversityWebApplication.Models.University;
using UniversityWebApplication.Providers.University;

namespace UniversityWebApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly IDataProvider<Student> studentProvider;

        public StudentController(IDataProvider<Student> studentProvider)
        {
            this.studentProvider = studentProvider;
        }

        // GET: Student/Index
        public ActionResult Index()
        {
            return View(studentProvider.GetAll());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View(studentProvider.Get(id));
        }

        [HttpGet]
        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                studentProvider.Add(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View(studentProvider.Get(id));
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                studentProvider.Update(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(student);
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View(studentProvider.Get(id));
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student student)
        {
            try
            {
                studentProvider.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(student);
            }
        }
    }
}
