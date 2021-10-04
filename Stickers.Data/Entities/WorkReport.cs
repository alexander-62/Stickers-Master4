using System;
using Stickers.Data.Model.Constants;

namespace Stickers.Data.Entities
{
    public class WorkReport
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? RollId { get; set; }
        public WorkType WorkType { get; set; }
        public int PaperCount { get; set; }
        public string PaperParameters { get; set; }
        public decimal? PlotteringLength { get; set; }
        public DateTime Date { get; set; }
        public int? UserId { get; set; }
        public int? OrderItemId { get; set; }
        public virtual User User { get; set; }
        public virtual OrderItem OrderItem { get; set; }
        public virtual Roll Roll { get; set; }

        public decimal? SpentMaterial { get; set; }
        public decimal? CostMaterial { get; set; }
        public decimal? PaintCost { get; set; }
    }
}
