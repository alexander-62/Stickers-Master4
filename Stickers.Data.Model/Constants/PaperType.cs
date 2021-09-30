using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum PaperType
    {
        [Description("Другое")]
        Other = 0,
        [Description("А3")]
        A3 = 1,
        [Description("А4")]
        A4 = 2,
        [Description("А5")]
        A5 = 3,
        [Description("А6")]
        A6 = 4,
        [Description("А7")]
        A7 = 5,
    }
}
