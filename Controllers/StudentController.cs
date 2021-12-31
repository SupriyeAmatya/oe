using Microsoft.AspNetCore.Mvc;
using oe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oe.Controllers
{
    public class StudentController : Controller
    {
        private readonly onlineExaminationContext _db;

        public StudentController(onlineExaminationContext db)
        {

            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.Students.ToList();
            return View(displaydata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Add(student);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.Students.FindAsync(id);
            return View(getempdetails);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Update(student);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student);

        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.Students.FindAsync(id);
            return View(getempdetails);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.Students.FindAsync(id);
            return View(getempdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getempdetails = await _db.Students.FindAsync(id);
            _db.Students.Remove(getempdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
