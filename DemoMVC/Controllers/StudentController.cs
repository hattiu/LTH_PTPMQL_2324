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
            var model = await _context.Students.ToListAsync();
            return View(model);
        }

        //action tra ve view de them moi sinh vien

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //action xu ly du lieu sinh vien giui len tu view va luu va databse
        public async Task<IActionResult> Create(StudentController std)
        {
            if(ModelState.IsValid)
            {
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
        return View(std);
        private bool StudentExists(string id)
        {
            return _context.Students.Any(e => e.StudentID == id);
        }

        //GET: Student/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if(student == null)
            {
                return NotFound();
            }
        }
        return View(student);

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
        }
    }
}