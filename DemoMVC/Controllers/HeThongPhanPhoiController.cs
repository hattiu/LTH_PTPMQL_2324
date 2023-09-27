using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;
using DemoMVC.Models.Process;

namespace DemoMVC.Controllers
{
    public class HePhongPhanPhoiController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ExcelProcess _excelProcess = new ExcelProcess();

        public HePhongPhanPhoiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HePhongPhanPhoi
        public async Task<IActionResult> Index()
        {
              return _context.HeThongPhanPhois != null ? 
                          View(await _context.HeThongPhanPhois.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.HeThongPhanPhois'  is null.");
        }

        // GET: HePhongPhanPhoi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.HeThongPhanPhois == null)
            {
                return NotFound();
            }

            var heThongPhanPhoi = await _context.HeThongPhanPhois
                .FirstOrDefaultAsync(m => m.MaHeThong == id);
            if (heThongPhanPhoi == null)
            {
                return NotFound();
            }

            return View(heThongPhanPhoi);
        }

        // GET: HePhongPhanPhoi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HePhongPhanPhoi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHeThong,HeThongPhanPhoiName,Address,NamHeThong")] HeThongPhanPhoi heThongPhanPhoi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(heThongPhanPhoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(heThongPhanPhoi);
        }

        // GET: HePhongPhanPhoi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.HeThongPhanPhois == null)
            {
                return NotFound();
            }

            var heThongPhanPhoi = await _context.HeThongPhanPhois.FindAsync(id);
            if (heThongPhanPhoi == null)
            {
                return NotFound();
            }
            return View(heThongPhanPhoi);
        }

        // POST: HePhongPhanPhoi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHeThong,HeThongPhanPhoiName,Address,NamHeThong")] HeThongPhanPhoi heThongPhanPhoi)
        {
            if (id != heThongPhanPhoi.MaHeThong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(heThongPhanPhoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeThongPhanPhoiExists(heThongPhanPhoi.MaHeThong))
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
            return View(heThongPhanPhoi);
        }

        // GET: HePhongPhanPhoi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.HeThongPhanPhois == null)
            {
                return NotFound();
            }

            var heThongPhanPhoi = await _context.HeThongPhanPhois
                .FirstOrDefaultAsync(m => m.MaHeThong == id);
            if (heThongPhanPhoi == null)
            {
                return NotFound();
            }

            return View(heThongPhanPhoi);
        }

        // POST: HePhongPhanPhoi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.HeThongPhanPhois == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HeThongPhanPhois'  is null.");
            }
            var heThongPhanPhoi = await _context.HeThongPhanPhois.FindAsync(id);
            if (heThongPhanPhoi != null)
            {
                _context.HeThongPhanPhois.Remove(heThongPhanPhoi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeThongPhanPhoiExists(string id)
        {
          return (_context.HeThongPhanPhois?.Any(e => e.MaHeThong == id)).GetValueOrDefault();
        }
        //phan file excel
        public async Task<IActionResult> Upload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Upload(IFormFile file)
        {
            if (file!=null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension != ".xls" && fileExtension != ".xls")
                {
                    ModelState.AddModelError ("","");
                }
                else
                {
                    //rename file when upload to sever
                    var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Upload/Excel", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();
                    using (var stream = new FileStream (filePath, FileMode.Create))
                    {
                        //save file to sever
                        await file.CopyToAsync(stream);
                        var dt = _excelProcess.ExcelToDataTable(fileLocation);
                        //using for loop to read data from dt
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var htpp = new HeThongPhanPhoi();
                            //set value to attributes
                            htpp.MaHeThong = dt.Rows[i][0].ToString();
                            htpp.HeThongPhanPhoiName = dt.Rows[i][1].ToString();
                            htpp.Address = dt.Rows[i][2].ToString();
                            htpp.NamHeThong = dt.Rows[i][3].ToString();
                            //add object to context
                            _context.Add(htpp);
                           
                        }
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View();
        }
    }
}
