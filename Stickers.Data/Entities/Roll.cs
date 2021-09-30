using Stickers.Data.Model.Constants;

namespace Stickers.Data.Entities
{
    public class Roll
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public string Manufacturer { get; set; }
        public int FilmThickness { get; set; }
        public decimal Width { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Length { get; set; }
        public virtual Film Film { get; set; }
    }
}
