using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<int, string> Reviews { get; set; } //int = 1-5 arasi deyerlendirme, string = aciqlama
        public double Price { get; set; }
        public int SoldCount { get; set; }
        public int StockCount { get; set; }
        public bool IsDelivery { get; set; }
        public bool IsDiscount { get; set; }
        public double DiscountPrice { get; set; }
        public bool HasWarranty { get; set; }
        public string Color { get; set; }
        public ProductCategory Category { get; set; }
    }
}
