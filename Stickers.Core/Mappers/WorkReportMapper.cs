using Stickers.Core.Utilities;
using Stickers.Data.Entities;
using Stickers.Data.Model.Views;
using System.Collections.Generic;
using System.Linq;

namespace Stickers.Core.Mappers
{
    public class WorkReportMapper
    {
        private readonly OrderItemMapper _orderItemMapper;

        public WorkReportMapper()
        {
            _orderItemMapper = new OrderItemMapper();
        }

        public WorkReportView Map(WorkReport report)
        {
            return new WorkReportView
            {
                Id = report.Id,
                OrderId = report.OrderId,
                WorkType = EnumUtility.GetEnumDescription(report.WorkType),
                OrderItemName = report.OrderItem?.Name,
                PaperCount = report.PaperCount,
                PaperParameters = report.PaperParameters,
                PlotteringLength = report.PlotteringLength,
                Date = report.Date,
                UserName = report.User.Name,
                RollId = report.RollId,
                SpentMaterial = report.SpentMaterial,
                CostMaterial = report.CostMaterial,
                PaintCost = report.PaintCost,
                OrderItemView = report.OrderItem == null ? null : _orderItemMapper.Map(report.OrderItem),
            };
        }

        public List<WorkReportView> MapList(List<WorkReport> reports)
        {
            return reports.Select(Map).ToList();
        }
    }
}
