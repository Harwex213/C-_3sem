using System.Windows.Media.Imaging;

namespace S2_Lab10
{
    public class ProductInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public int IconId { get; set; }
        public BitmapFrame Photo { get; set; }
    }
}