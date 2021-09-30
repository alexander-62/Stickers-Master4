using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stickers.Data.Model.Views
{
    public class OrderItemView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
        public int FilmId { get; set; }
        public string ClientName { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? ApproximalDeliveryDate { get; set; }
        public string DeliveryType { get; set; }
        public string Film { get; set; }
        public string CommentForDesigner { get; set; }
        public string CommentForProduction { get; set; }
        public string Lamination { get; set; }
        public string Status { get; set; }
        public string CuttingType { get; set; }
        public decimal CuttingLength { get; set; }
        public bool IsUrgent { get; set; }
        public decimal OverallCuttingLength { get; set; }
        public int PaperCount { get; set; }
        public string PaperParameters { get; set; }
        public decimal PaperWidth { get; set; }
        public decimal PaperLength { get; set; }
        public decimal ItemCost { get; set; }
        public decimal ItemCostPerPaper { get; set; }
        public int PrintedCount { get; set; }
        public int LaminatedCount { get; set; }
        public int PlotteredCount { get; set; }
        public int CutCount { get; set; }
        public decimal OverallPrintingArea { get; set; }
        public decimal OverallLaminationArea { get; set; }
        public string ContourDrawnBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int Discount { get; set; }
        public bool IsManualPricing { get; set; }
      
        [NotMapped]
        public int? DaysFromConfirmation { get; set; }
    }
}
