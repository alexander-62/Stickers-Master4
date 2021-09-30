using Stickers.Data.Model.Constants;

namespace Stickers.Data.Entities
{
    public class Cost
    {
        public int Id { get; set; }
        public CostType CostType { get; set; }
        public decimal Price { get; set; }
    }
}
