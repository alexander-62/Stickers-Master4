using System.Collections.Generic;

namespace Stickers.Data.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Roll> Rolls { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
