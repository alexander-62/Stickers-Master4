using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum CuttingType
    {
        [Description("Не выбрана")]
        NotSelected = 0,
        [Description("Без резки")]
        None = 1,
        [Description("Сквозная")]
        Through = 2,
        [Description("Контурная")]
        Contour = 3,
    }
}
