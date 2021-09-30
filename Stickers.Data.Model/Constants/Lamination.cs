using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum Lamination
    {
        [Description("Не выбрана")]
        NotSelected = 0,
        [Description("Без ламинации")]
        None = 1,
        [Description("Глянцевая")]
        Glossy = 2,
        [Description("Матовая")]
        Opaque = 3,
    }
}
