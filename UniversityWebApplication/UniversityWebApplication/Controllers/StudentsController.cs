using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Models.University;

namespace UniversityWebApplication.Controllers
{


    public class StudentsController : Controller
    {


        public StudentsController()
        {
            
        }

        private static List<Student> data = new List<Student>
            {
                new Student{Id = 1, City = "vilnius", Name = "Petras petraitis", Score = 5.5}
            };


        // GET: StudentsController
        public ActionResult Index()
        {
            return View(data);
        }

        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            return View(data.FirstOrDefault(s => s.Id == id));
            //return View(data.Find(id));
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View(new Student { Name = "NAME ME!" });
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student newStudent)
        {
            try
            {
                // add entry to db.
                data.Add(newStudent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(newStudent);
            }
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(data.FirstOrDefault(s => s.Id == id));
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                data.RemoveAll(s => s.Id == id);
                data.Add(student);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(student);
            }
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(data.FirstOrDefault(s => s.Id == id));
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student student)
        {
            try
            {
                data.RemoveAll(s => s.Id == id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(student);
            }
        }
    }
}
