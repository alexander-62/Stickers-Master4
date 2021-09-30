using Stickers.Core.Utilities;
using Stickers.Data.Model.Constants;

namespace Stickers.Core.Services
{
    public class PaperParametersService
    {
        public decimal GetPaperLength(PaperType paperType, string userInput)
        {
            switch (paperType)
            {
                case PaperType.A3:
                    return 420;
                case PaperType.A4:
                    return 297;
                case PaperType.A5:
                    return 210;
                case PaperType.A6:
                    return 148;
                case PaperType.A7:
                    return 105;
                case PaperType.Other:
                    return decimal.Parse(userInput);
                default:
                    return 0;
            }
        }

        public decimal GetPaperWidth(PaperType paperType, string userInput)
        {
            switch (paperType)
            {
                case PaperType.A3:
                    return 297;
                case PaperType.A4:
                    return 210;
                case PaperType.A5:
                    return 148;
                case PaperType.A6:
                    return 105;
                case PaperType.A7:
                    return 74;
                case PaperType.Other:
                    return decimal.Parse(userInput);
                default:
                    return 0;
            }
        }

        public string GetPaperParametersDescription(decimal length, decimal width)
        {
            if (length == 420 && width == 297)
            {
                return EnumUtility.GetEnumDescription(PaperType.A3) + " (420 * 297)";
            }
            if (length == 297 && width == 210)
            {
                return EnumUtility.GetEnumDescription(PaperType.A4) + " (297 * 210)";
            }
            if (length == 210 && width == 148)
            {
                return EnumUtility.GetEnumDescription(PaperType.A5) + " (210 * 148)";
            }
            if (length == 148 && width == 105)
            {
                return EnumUtility.GetEnumDescription(PaperType.A6) + " (148 * 105)";
            }
            if (length == 105 && width == 74)
            {
                return EnumUtility.GetEnumDescription(PaperType.A7) + " (105 * 74)";
            }

            return $"{length} * {width}";
        }

        public PaperType GetPaperTypeByLengthAndWidth(decimal length, decimal width)
        {
            if (length == 420 && width == 297)
            {
                return PaperType.A3;
            }
            if (length == 297 && width == 210)
            {
                return PaperType.A4;
            }
            if (length == 210 && width == 148)
            {
                return PaperType.A5;
            }
            if (length == 148 && width == 105)
            {
                return PaperType.A6;
            }
            if (length == 105 && width == 74)
            {
                return PaperType.A7;
            }

            return PaperType.Other;
        }
    }
}
