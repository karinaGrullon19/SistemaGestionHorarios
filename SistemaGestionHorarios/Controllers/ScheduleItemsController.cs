using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaGestionHorarios.Infrastructure;
using SistemaGestionHorarios.Domain;

namespace SistemaGestionHorarios.Controllers
{
    public class ScheduleItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScheduleItemsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: api/schedule (Lista de horarios)
        public async Task<IActionResult> Index()
        {
            return View(await _context.ScheduleItems.ToListAsync());
        }

        public IActionResult Create() => View();

        // POST: api/schedule (Guardar nuevo bloque)
        [HttpPost]
        public async Task<IActionResult> Create(ScheduleItem item)
        {
            _context.ScheduleItems.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}