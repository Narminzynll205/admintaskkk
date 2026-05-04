using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL;
using WebApplication4.Models;

namespace WebApplication4.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        [Area("Admin")]
        private readonly AppDbContext _db;
        public SliderController(AppDbContext db)
        {
            _db = db;
        public IActionResult Index()
        {

            List<Slider> sliders = _db.Sliders.ToList();
            return View(sliders);

            public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            _db.Sliders.Add(slider);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        public IActionResult Delete(int? id)
        {
            Slider slider = _db.Sliders.Find(id);
            _db.Sliders.Remove(slider);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


       
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Slider slider = _db.Sliders.Find(id);
            slider.IsDeleted = true;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

       
        [HttpPost]
        public IActionResult Restore(int id)
        {
            Slider slider = _db.Sliders.Find(id);
            slider.IsDeleted = false;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
