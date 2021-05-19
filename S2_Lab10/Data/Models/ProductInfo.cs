using System;
using System.Windows.Media.Imaging;

namespace S2_Lab10
{
    public class ProductInfo : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public int IconId { get; set; }
        public BitmapFrame Photo { get; set; }
        
        public object Clone()
        {
            return new ProductInfo
            {
                Id = this.Id,
                Name = this.Name,
                Weight = this.Weight,
                Price = this.Weight,
                IconId = this.IconId,
                Photo = this.Photo
            };
        }
    }
}