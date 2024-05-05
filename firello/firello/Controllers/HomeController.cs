using System;
using firello.Data;
using firello.Models;
using firello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace firello.Controllers
{
	public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo slidersInfo = await _context.SliderInfos.FirstOrDefaultAsync();
            //List<Category> categories = await _context.Categories.ToListAsync();
            //List<Product> products = await _context.Products.Include(m => m.ProductImages).ToListAsync();
            //SurpriseImage surprsiseImages = await _context.SurpriseImages.FirstOrDefaultAsync();
            //SurprisePanel supriseText = await _context.SurpriseText.FirstOrDefaultAsync();
            //List<Expert> experts = await _context.Experts.ToListAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = slidersInfo
            };
            
            return View(model);
        }

    }
}
