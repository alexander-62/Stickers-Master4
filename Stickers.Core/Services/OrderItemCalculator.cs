using System;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.Core.Services
{
    public class OrderItemCalculator
    {
        private readonly CostsService _costsService;
        private readonly FilmService _filmService;

        public OrderItemCalculator()
        {
            _costsService = new CostsService();
            _filmService = new FilmService();
        }

        public decimal CalculateCost(OrderItem orderItem, bool isUrgent)
        {
            if (orderItem.IsManualPricing)
            {
                return orderItem.ItemCost;
            }
            
            
            var costs = _costsService.GetCosts();            
            if (costs.Count != 9)
            {
                throw new Exception("Заполните таблицу расценок.");
            }
            
            var printCost = costs.Find(x => x.CostType == CostType.PrintCost).Price;
            var filmCost = _filmService.GetFilmById(orderItem.FilmId).Price;
            var cuttingCost = 0m;
            switch (orderItem.CuttingType)
            {
                case CuttingType.Through:
                    cuttingCost = costs.Find(x => x.CostType == CostType.CuttingThroughCost).Price;
                    break;
                case CuttingType.Contour:
                    cuttingCost = costs.Find(x => x.CostType == CostType.CuttingContourCost).Price;
                    break;
            }

            var laminationCost = 0m;
            switch (orderItem.Lamination)
            {
                case Lamination.Glossy:
                    laminationCost = costs.Find(x => x.CostType == CostType.GlossyLaminationCost).Price;
                    break;
                case Lamination.Opaque:
                    laminationCost = costs.Find(x => x.CostType == CostType.OpaqueLaminationCost).Price;
                    break;
            }

            var minimalSquare = costs.Find(x => x.CostType == CostType.MinimalPaperSquare).Price;
            var minimalPaperCuttingCost = costs.Find(x => x.CostType == CostType.MinimalPaperCuttingCost).Price;

            var paperSquare = orderItem.PaperLength * orderItem.PaperWidth / 1000000;
            var overallSquare = paperSquare * orderItem.PaperCount;
            var sum = overallSquare * printCost +
                overallSquare * filmCost +
                orderItem.CuttingLength * cuttingCost * orderItem.PaperCount +
                overallSquare * laminationCost;
            if (paperSquare < minimalSquare)
            {
                sum += orderItem.PaperCount * minimalPaperCuttingCost;
            }

            if (isUrgent)
            {
                sum *= 1 + costs.Find(x => x.CostType == CostType.UrgencyCost).Price / 100;
            }

            sum *= (decimal)(100 - orderItem.Discount) / 100;

            return sum;
        }
    }
}
