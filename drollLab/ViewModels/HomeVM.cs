using System;
using drollLab.Models;
using static System.Net.Mime.MediaTypeNames;

namespace drollLab.ViewModels
{
	public class HomeVM
	{
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<ProductImage> productImages { get; set; }
    }
}

