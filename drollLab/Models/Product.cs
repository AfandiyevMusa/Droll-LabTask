using System;
namespace drollLab.Models
{
	public class Product:BaseEntity
	{
		public string Size { get; set; }
		public decimal Price { get; set; }
        public ICollection<ProductImage> productImages { get; set; }
    }
}

