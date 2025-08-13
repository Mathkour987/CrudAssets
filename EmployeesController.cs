using CrudAssets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class EmployeesController : Controller
{
    private readonly AppDbContext _context;
    public EmployeesController(AppDbContext context) => _context = context;

   
    public async Task<IActionResult> Index()
    {
        var employees = await _context.Employees.Include(e => e.Assets).ToListAsync();
        return View(employees);
    }

   
    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Employee employee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(employee);
    }

    
}
