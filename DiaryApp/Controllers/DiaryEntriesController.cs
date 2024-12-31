using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            return View(entries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            _db.DiaryEntries.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
