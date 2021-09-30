using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum DeliveryType
    {
        [Description("Не выбран")]
        None = 0,
        [Description("Почта России")]
        RussianPost = 1,
        [Description("СДЭК")]
        SDEK = 2,
        [Description("Курьер")]
        Courier = 3,
        [Description("Боксберри")]
        Boksberry = 4,
        [Description("Самовывоз")]
        Pickup = 5
    }
}
