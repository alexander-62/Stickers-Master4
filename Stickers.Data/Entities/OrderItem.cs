using System;
using System.Collections.Generic;
using Stickers.Data.Model.Constants;

namespace Stickers.Data.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
        public int FilmId { get; set; }
        public string CommentForDesigner { get; set; }
        public string CommentForProduction { get; set; }
        public Lamination Lamination { get; set; }
        public OrderItemStatus Status { get; set; }
        public CuttingType CuttingType { get; set; }
        public decimal CuttingLength { get; set; }
        public int PaperCount { get; set; }
        public int PrintedCount { get; set; }
        public int LaminatedCount { get; set; }
        public int PlotteredCount { get; set; }
        public int CutCount { get; set; }
        public decimal PaperWidth { get; set; }
        public decimal PaperLength { get; set; }
        public decimal ItemCost { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int Discount { get; set; }
        public bool IsManualPricing { get; set; }
        public virtual Order Order { get; set; }
        public virtual Film Film { get; set; }
        public virtual List<WorkReport> WorkReports { get; set; }
    }
}