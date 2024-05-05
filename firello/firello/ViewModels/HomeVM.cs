﻿using System;
using firello.Models;

namespace firello.ViewModels
{
	public class HomeVM
	{
        public List<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }

        public SurpriseImage SurpriseImages { get; set; }
        public SurprisePanel SupriseText { get; set; }
        public List<Expert> Experts { get; set; }

    }
}

