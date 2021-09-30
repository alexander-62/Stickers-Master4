using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum WorkType
    {
        [Description("Печать")]
        Printing = 0,
        [Description("Ламинация")]
        Lamination = 1,
        [Description("Плоттерная резка")]
        Plottering = 2,
        [Description("Нарезка на листы")]
        Cutting = 3,
        [Description("Брак")]
        Failure = 4,
        [Description("Рисование контура")]
        DrawContour = 5,
        [Description("Внесение заказа")]
        OrderInsert = 6,
        [Description("Согласование заказа")]
        OrderConfirmation = 7,
        [Description("Снятие заказа с согласования")]
        OrderDeconfirmation = 8,
        [Description("Отметка оплаты")]
        CheckPayment = 9,
    }
}
