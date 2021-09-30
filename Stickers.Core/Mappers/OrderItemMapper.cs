using System.Collections.Generic;
using System.Linq;
using Stickers.Core.Services;
using Stickers.Core.Utilities;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;
using Stickers.Data.Model.Views;

namespace Stickers.Core.Mappers
{
    public class OrderItemMapper
    {
        private readonly PaperParametersService _paperParametersService;
        public OrderItemMapper()
        {
            _paperParametersService = new PaperParametersService();
        }

        public OrderItemView Map(OrderItem orderItem)
        {
            var contourReport = orderItem.WorkReports?
                .Where(x => x.WorkType == WorkType.DrawContour)
                .OrderByDescending(x => x.Date)
                .FirstOrDefault();
            return new OrderItemView
            {
                Id = orderItem.Id,
                Name = orderItem.Name,
                OrderId = orderItem.OrderId,
                ClientName = orderItem.Order?.Client.Name,
                FilmId = orderItem.FilmId,
                ConfirmedDate = orderItem.Order?.ConfirmedDate,
                ApproximalDeliveryDate = orderItem.Order?.ApproximalDeliveryDate,
                DeliveryType = orderItem.Order == null ? string.Empty : EnumUtility.GetEnumDescription(orderItem.Order?.DeliveryType),
                Film = orderItem.Film.Name,
                CommentForDesigner = orderItem.CommentForDesigner,
                CommentForProduction = orderItem.CommentForProduction,
                Lamination = EnumUtility.GetEnumDescription(orderItem.Lamination),
                Status = EnumUtility.GetEnumDescription(orderItem.Status),
                CuttingType = EnumUtility.GetEnumDescription(orderItem.CuttingType),
                CuttingLength = orderItem.CuttingLength,
                OverallCuttingLength = orderItem.CuttingLength * orderItem.PaperCount,
                PaperCount = orderItem.PaperCount,
                PaperParameters =
                    _paperParametersService.GetPaperParametersDescription(orderItem.PaperLength, orderItem.PaperWidth),
                ItemCost = orderItem.ItemCost,
                ItemCostPerPaper = orderItem.ItemCost / orderItem.PaperCount,
                IsUrgent = orderItem.Order?.IsUrgent ?? false,
                PrintedCount = orderItem.PrintedCount,
                LaminatedCount = orderItem.LaminatedCount,
                PlotteredCount = orderItem.PlotteredCount,
                CutCount = orderItem.CutCount,
                OverallPrintingArea = orderItem.PaperCount * (orderItem.PaperLength * orderItem.PaperWidth / 1000000),
                OverallLaminationArea = orderItem.Lamination == Lamination.None ? 0 : orderItem.PaperCount * (orderItem.PaperLength * orderItem.PaperWidth / 1000000),
                ContourDrawnBy = contourReport?.User.Name,
                CreatedDateTime = orderItem.CreatedDateTime,
                PaperWidth = orderItem.PaperWidth,
                PaperLength = orderItem.PaperLength,
                Discount = orderItem.Discount,
                IsManualPricing = orderItem.IsManualPricing
            };
        }

        public List<OrderItemView> MapList(List<OrderItem> orderItems)
        {
            return orderItems.Select(Map).ToList();
        }
    }
}
