using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum UserRole
    {
        [Description("Гость")]
        Guest = 0,
        [Description("Работник")]
        Worker = 1,
        [Description("Дизайнер")]
        Designer = 2,
        [Description("Менеджер")]
        Manager = 3,
        [Description("Администратор")]
        Administrator = 4
    }
}
