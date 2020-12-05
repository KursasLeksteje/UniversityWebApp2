using Microsoft.AspNetCore.Mvc;
using UniversityWebApplication.Models.University;
using UniversityWebApplication.Providers.University;

namespace UniversityWebApplication.Controllers
{
    public class CourseController : Controller
    {
        private readonly IDataProvider<Course> dataProvider;

        public CourseController(IDataProvider<Course> dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        // GET: CourseController
        public ActionResult Index()
        {
            return View(dataProvider.GetAll());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View(dataProvider.Get(id));
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
                dataProvider.Add(course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(course);
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(dataProvider.Get(id));
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                dataProvider.Update(course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(course);
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(dataProvider.Get(id));
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Course course)
        {
            try
            {
                dataProvider.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
