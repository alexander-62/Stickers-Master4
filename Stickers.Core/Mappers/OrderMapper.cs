using System;
using Stickers.Core.Utilities;
using Stickers.Data.Entities;
using Stickers.Data.Model.Views;
using System.Collections.Generic;
using System.Linq;
using Stickers.Core.Services;
using Stickers.Data.Model.Constants;

namespace Stickers.Core.Mappers
{
    public class OrderMapper
    {
        private readonly OrderItemMapper _orderItemMapper;
        private readonly WorkReportService _workReportService;

        public OrderMapper()
        {
            _orderItemMapper = new OrderItemMapper();
            _workReportService = new WorkReportService();
        }

        public OrderFullView MapFullView(Order order)
        {
            var view = new OrderFullView(Map(order));
            var orderReports = _workReportService.GetReportsForOrder(order.Id);
            view.InsertedDate = orderReports.FirstOrDefault(x => x.WorkType == WorkType.OrderInsert)?.Date;
            view.ConfirmedBy = orderReports
                .Where(x => x.WorkType == WorkType.OrderConfirmation)
                .OrderByDescending(o => o.Date)
                .FirstOrDefault()?.User?.Name;
            if (order.Status == OrderStatus.ReadyForDelivery || order.Status == OrderStatus.Delivered)
            {
                view.OrderDoneDate = orderReports
                    .Where(x => x.WorkType == WorkType.Cutting)
                    .OrderByDescending(x => x.Date)
                    .FirstOrDefault()?.Date;
            }
            if (order.IsPayed)
            {
                view.PaymentCheckedBy = orderReports.FirstOrDefault(x => x.WorkType == WorkType.CheckPayment)?.User?.Name;
                view.PaymentCheckedDate = orderReports.FirstOrDefault(x => x.WorkType == WorkType.CheckPayment)?.Date;
            }
            return view;
        }

        public OrderView Map(Order order)
        {
            var stickersCost = order.OrderItems.Sum(x => x.ItemCost);
            return new OrderView
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                ApproximalDeliveryDate = order.ApproximalDeliveryDate,
                ConfirmedDate = order.ConfirmedDate,
                Comment = order.Comment,
                DeliveryDate = order.DeliveryDate,
                DeliveryAddress = order.DeliveryAddress,
                ReceiverCredentials = order.ReceiverCredentials,
                PostIndex = order.PostIndex,
                DeliveryType = EnumUtility.GetEnumDescription(order.DeliveryType),
                DeliveryCost = order.DeliveryCost,
                TrackIdentifier = order.TrackIdentifier,
                IsPayed = order.IsPayed,
                IsArchived = order.IsArchived,
                PaymentMethod = EnumUtility.GetEnumDescription(order.PaymentMethod),
                IsUrgent = order.IsUrgent,
                Status = EnumUtility.GetEnumDescription(order.Status),
                ClientName = order.Client.Name,
                OrderItems = _orderItemMapper.MapList(order.OrderItems.ToList()),
                StickersCost = stickersCost,
                OrderCost = order.DeliveryCost + stickersCost,
                InsertedBy = order.InsertedBy,
                DaysFromConfirmation = order.ConfirmedDate.HasValue ? (DateTime.Now - order.ConfirmedDate.Value).Days : (int?)null,
                OrdersCount = order.OrderItems.Count
            };
        }

        public List<OrderView> MapList(List<Order> orders)
        {
            return orders.Select(Map).ToList();
        }
    }
}
