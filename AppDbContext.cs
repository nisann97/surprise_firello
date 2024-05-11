using System;
using test.Models;
using Microsoft.EntityFrameworkCore;
namespace test.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{

		}

		public DbSet<Slider> Sliders { get; set; }
		public DbSet<SliderInfo> SlidersInfo { get; set; }
		public DbSet<Category> Categories  { get; set; }
		public DbSet<Product> Products  { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Surprise> Surprises { get; set; }
        public DbSet<SurpriseBulletPoints> SurpriseBulletPoints { get; set; }
		public DbSet<ExpertPanel> ExpertPanel { get; set; }
		public DbSet<Expert> Experts { get; set; }

	}
}

