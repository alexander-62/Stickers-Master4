using System;
using Microsoft.EntityFrameworkCore;
using Stickers.Core.Mappers;
using Stickers.Data.Context;
using Stickers.Data.Entities;
using Stickers.Data.Model.Views;
using System.Collections.Generic;
using System.Linq;
using Stickers.Data.Model.Constants;
using Stickers.Core.Utilities;

namespace Stickers.Core.Services
{
    public class OrdersService
    {
        private readonly OrderMapper _orderMapper;

        public OrdersService()
        {
            _orderMapper = new OrderMapper();
        }

        public List<OrderView> GetAllOrderViews()//
        {
            using var context = new StickersDbContext();
            var orders = context.Orders
                .Include(x => x.Client)
                .Include(x => x.OrderItems).ThenInclude(x => x.Film).ToList();
            return _orderMapper.MapList(orders);
        }

        public List<OrderView> GetOrderViews()
        {
            using var context = new StickersDbContext();
            var orders = context.Orders
                .Include(x => x.Client)
                .Include(x => x.OrderItems).ThenInclude(x => x.Film)
                .Where(x => !x.IsArchived)
                .ToList();
            return _orderMapper.MapList(orders);
        }

        public List<OrderView> GetArchivedOrderViews()
        {
            using var context = new StickersDbContext();
            var orders = context.Orders
                .Include(x => x.Client)
                .Include(x => x.OrderItems).ThenInclude(x => x.Film)
                .Where(x => x.IsArchived)
                .ToList();
            return _orderMapper.MapList(orders);
        }

        public List<OrderView> GetOrderViewsForDelivery()
        {
            using var context = new StickersDbContext();
            var orders = context.Orders
                .Include(x => x.Client)
                .Include(x => x.OrderItems).ThenInclude(x => x.Film)
                .Where(x => !x.IsArchived)
                .Where(x => x.Status == OrderStatus.ReadyForDelivery || x.Status == OrderStatus.Delivered)
                .ToList();
            return _orderMapper.MapList(orders);
        }

        public decimal GetOverallCost(List<int> orderIds)
        {
            using var context = new StickersDbContext();
            var orders = context.Orders.Where(x => orderIds.Contains(x.Id)).Include(x=>x.OrderItems).ToList();
            return orders.Sum(x => x.OrderItems.Sum(o => o.ItemCost));
        }

        public Order GetOrderById(int id)
        {
            using var context = new StickersDbContext();
            return context.Orders
                .Include(x => x.Client)
                .Include(x => x.OrderItems).ThenInclude(x => x.Film)
                .FirstOrDefault(x => x.Id == id);
        }

        public List<int> GetOrderIdsDeliveredInBetween(DateTime? startDate, DateTime? endDate)
        {
            using var context = new StickersDbContext();
            var orders = context.Orders.ToList();
            return orders.Where(x =>
                    x.DeliveryDate.HasValue && CheckDeliveryDate(x.DeliveryDate.Value, startDate, endDate))
                .Select(x => x.Id).ToList();
        }

        public OrderView UpdateOrder(Order order)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Order>(context);
            var itemsRepository = new Repository<OrderItem>(context);
            if (order.OrderItems.All(x => x.Status == OrderItemStatus.ContourDrawn) &&
                order.Status == OrderStatus.NotStarted)
            {
                order.Status = OrderStatus.ContoursDrawn;
            }

            foreach (var item in order.OrderItems)
            {
                item.Film = null;
            }

            var oldOrder = GetOrderById(order.Id);
            foreach (var item in oldOrder.OrderItems)
            {
                if (order.OrderItems.All(x => x.Id != item.Id))
                {
                    itemsRepository.Delete(item.Id);
                }
            }
            foreach (var item in order.OrderItems)
            {
                if (oldOrder.OrderItems.Any(x => x.Id == item.Id))
                {
                    itemsRepository.Update(item);
                }
                else
                {
                    item.OrderId = order.Id;
                    itemsRepository.Add(item);
                }
            }

            var newOrder = repository.Update(order);

            return GetOrderViewById(newOrder.Id);
        }

        public OrderFullView GetOrderFullViewById(int id)
        {
            using var context = new StickersDbContext();
            var orderWithIncludes = context.Orders
                .Include(x => x.Client)
                .Include(x => x.OrderItems).ThenInclude(x => x.Film)
                .FirstOrDefault(x => x.Id == id);
            return _orderMapper.MapFullView(orderWithIncludes);
        }

        private OrderView GetOrderViewById(int id)
        {
            using var context = new StickersDbContext();
            var orderWithIncludes = context.Orders
                .Include(x => x.Client)
                .Include(x => x.OrderItems).ThenInclude(x => x.Film)
                .FirstOrDefault(x => x.Id == id);
            return _orderMapper.Map(orderWithIncludes);
        }

        public OrderView AddOrder(Order order)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<Order>(context);
            foreach (var item in order.OrderItems)
            {
                item.Film = null;
            }
            var newOrder = repository.Add(order);
            return GetOrderViewById(newOrder.Id);
        }

        public void DeleteOrder(int id)
        {
            try
            {
                using var context = new StickersDbContext();
                var repository = new Repository<Order>(context);
                var result = repository.Delete(id);
                if (result == null)
                {
                    throw new Exception("Заказ уже удален.");
                }
            }
            catch
            {
                throw new Exception("Не надо удалять этот заказ. Ай-ай-ай.");
            }
        }

        private bool CheckDeliveryDate(DateTime actualDate, DateTime? startDate, DateTime? endDate)
        {
            if (!startDate.HasValue && !endDate.HasValue)
            {
                return false;
            }
            if(startDate.HasValue && !endDate.HasValue)
            {
                startDate = DateUtility.GetZeroTimeDate(startDate.Value);
                return actualDate >= startDate.Value;
            }
            if (!startDate.HasValue)
            {
                endDate = DateUtility.GetAlmostMidnightDate(endDate.Value);
                return actualDate <= endDate.Value;
            }

            startDate = DateUtility.GetZeroTimeDate(startDate.Value);
            endDate = DateUtility.GetAlmostMidnightDate(endDate.Value);
            return actualDate >= startDate.Value && actualDate <= endDate.Value;
        }
    }
}