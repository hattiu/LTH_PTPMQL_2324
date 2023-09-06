using DemoMVC.Data;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        //khia bao DbContext de lam viec voi
        private readonly ApplicationDbContext _context;
        public StudentController (ApplicationDbContext context)
        {
            _context = context;
        }

        //action tra ve view de hien th danh sach

        public async Task<IActionResult> Index()
        {
            var model = await _context.Student.ToListAsync();
            return View(model);
        }

        //action tra ve view de them moi sinh vien
        //get: Student/Create
        public IActionResult Create()
        {
            ViewData["FacultyID"] = new SelectList(_context.Facuty, "FacultyID","FacultyName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //action xu ly du lieu sinh vien giui len tu view va luu va databse
        public async Task<IActionResult> Create([Bind("StudentID,StudentName,FacultyID")] Student student)
        {
            if(ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyID"] = new SelectList(_context.Facuty, "FacultyID","FacultyName", student.FacultyID);
            return View(student);
        }

        
        private bool StudentExists(string id)
        {
            return _context.Student.Any(e => e.StudentID == id);
        }

        //GET: Student/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null )
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);

        }
        

        //POST: student/edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StudentID, StudentName")] Student std)
        {
            if(id != std.StudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try 
                {
                    _context.Update(std);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(std.StudentID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(std);
            //get:Product/delete/5
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }
            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        //POST>Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Student == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Student'  is null.");
            }
            var student = await _context.Student.FindAsync(id);
            if (student != null)
            {
                _context.Student.Remove(student);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}