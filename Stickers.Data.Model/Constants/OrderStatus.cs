using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum OrderStatus
    {
        [Description("Рисование контуров")]
        NotStarted = 0,
        [Description("Согласование контуров")]
        ContoursDrawn = 1,
        [Description("Доработка контуров")]
        ContoursOnRevision = 2,
        [Description("Готов к печати")]
        ReadyForProduction = 3,
        [Description("В работе")]
        InProduction = 4,
        [Description("Готов к отправке")]
        ReadyForDelivery = 5,
        [Description("Отправлен")]
        Delivered = 6,
    }
}
