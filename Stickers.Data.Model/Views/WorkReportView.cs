using System;

namespace Stickers.Data.Model.Views
{
    public class WorkReportView
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string WorkType { get; set; }
        public int PaperCount { get; set; }
        public string PaperParameters { get; set; }
        public decimal? PlotteringLength { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string OrderItemName { get; set; }
        public int? RollId { get; set; }
        public OrderItemView OrderItemView { get; set; }
    }
}
