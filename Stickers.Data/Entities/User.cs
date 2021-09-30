using Stickers.Data.Model.Constants;

namespace Stickers.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; }
    }
}
