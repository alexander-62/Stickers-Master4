using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum OrderItemStatus
    {
        [Description("Поступил в работу")]
        NotStarted = 0,
        [Description("Контур нарисован")]
        ContourDrawn = 1,
        [Description("Контур на доработке")]
        ContourOnRevision = 2,
        [Description("Готов к работе")]
        ReadyForProduction = 3,
        [Description("В работе")]
        InProduction = 4,
        [Description("Сделан")]
        Done = 5,
    }
}
