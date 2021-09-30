using System.ComponentModel.DataAnnotations.Schema;

namespace Stickers.Data.Entities
{
    public class BusinessClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VkId { get; set; }
        public string Address { get; set; }
        public string PostIndex { get; set; }
        public string ReceiverCredentials { get; set; }
        public string Comment { get; set; }
        public string VkLink { get; set; }
        public string VkGroupName { get; set; }
        [NotMapped]
        public string N1 { get; set; }
        [NotMapped]
        public string N2 { get; set; }
        [NotMapped]
        public string N3 { get; set; }
        [NotMapped]
        public string N4 { get; set; }
    }
}