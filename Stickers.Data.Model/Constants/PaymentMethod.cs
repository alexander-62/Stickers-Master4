using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum PaymentMethod
    {
        [Description("Не выбран")]
        None = 0,
        [Description("Сбербанк")]
        Sberbank = 1,
        [Description("Тинькофф")]
        Tinkoff = 2,
        [Description("ВК деньги")]
        VkMoney = 3,
        [Description("По счету")]
        Bill = 4,
        [Description("Сайт Клейки")]
        Kleyki = 5,
        [Description("Другое")]
        Other = 6,
    }
}
