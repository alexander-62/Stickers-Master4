using System.ComponentModel;

namespace Stickers.Data.Model.Constants
{
    public enum CostType
    {
        [Description("Цена кв.м. печати")]
        PrintCost = 0,
        [Description("Цена сквозной резки")]
        CuttingThroughCost = 1,
        [Description("Цена контурной резки")]
        CuttingContourCost = 2,
        [Description("Цена глянцевой ламинации")]
        GlossyLaminationCost = 3,
        [Description("Цена матовой ламинации")]
        OpaqueLaminationCost = 4,
        [Description("Доплата за листы маленького формата")]
        MinimalPaperCuttingCost = 5,
        [Description("Минимальная площадь листа")]
        MinimalPaperSquare = 6,
        [Description("Наценка за срочность")]
        UrgencyCost = 7,
        //[Description("Цена краски, руб/м2")]
        //PaintCost = 8,
    }
}
